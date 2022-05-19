using System;
using System.ComponentModel;

namespace PumpLogic
{
    public class Pump : IPump
    {
        PumpState _state;
        decimal _pencePerLitre;
        readonly decimal _flowRatePerSecond;
        DateTime? _dispenseStart;
        TimeSpan? _elapsed;        

        public event PropertyChangedEventHandler PropertyChanged;

        public Pump(decimal price, decimal flowRatePerSecond)
        {
            _pencePerLitre = price;
            _state = PumpState.Holstered;
            _flowRatePerSecond = flowRatePerSecond;
        }

        #region Event Handling 

       
        void OnPropertyChanged(string s)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(s));
        }

        #endregion

        #region Properties 
        public PumpState CurrentPumpState { get { return _state; } }

        public string TransactionCostInPence { get { return (TransactionQuantity * _pencePerLitre).ToString("0.00"); } }

        public decimal TransactionQuantity {  
            get 
            {
                if (!_elapsed.HasValue)
                    return 0;
                return (decimal)_elapsed.Value.TotalMilliseconds / 1000 * _flowRatePerSecond;
            } 
        }


        public decimal PencePerLitre
        {
            get { return _pencePerLitre; }
            set
            {
                if (CurrentPumpState != PumpState.Holstered)
                    throw new PumpException("Cannot change price while pump is unholstered.");
                _pencePerLitre = value;
            }
        }

        #endregion 


        public void LiftNozzle()
        {
            if (CurrentPumpState != PumpState.Holstered)
                throw new PumpException("Cannot lift - Pump is not holstered.");
            _state = PumpState.JustUnholstered;
        }

        public void ReplaceNozzle()
        {
            if (CurrentPumpState != PumpState.JustUnholstered)
                throw new PumpException("Cannot replace - Pump is not unholstered");

            _state = PumpState.Holstered;
        }

        public void StartDispensing()
        {
            if (CurrentPumpState != PumpState.JustUnholstered)
                throw new PumpException("Cannot start dispensing - Pump is not unholstered.");

            if (_dispenseStart.HasValue)
                throw new PumpException("already dispensing");

            _state = PumpState.Dispensing;
            _dispenseStart = DateTime.Now;
            if (!_elapsed.HasValue)
                _elapsed = new TimeSpan(0);
        }

        public void StopDispensing()
        {
            if (CurrentPumpState != PumpState.Dispensing)
                throw new PumpException("Cannot stop dispensing - pump was not dispensing.");

            if (!_dispenseStart.HasValue)
                throw new PumpException("timer not started");

            _state = PumpState.JustUnholstered;
            _elapsed = _elapsed.Value.Add(DateTime.Now - _dispenseStart.Value);
            _dispenseStart = null;

            Report();

        }

        public void Report()
        {
            OnPropertyChanged("TransactionCostInPence");
        }

        public override string ToString()
        {
            return $"{TransactionQuantity} @ {_pencePerLitre} = {TransactionCostInPence}";
        }

    }
}
