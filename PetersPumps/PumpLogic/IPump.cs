using System;
using System.ComponentModel;

namespace PumpLogic
{

    public interface IPump : INotifyPropertyChanged
    {        
        void LiftNozzle();
        void ReplaceNozzle();
        void StartDispensing();
        void StopDispensing();
        void Report();
        PumpState CurrentPumpState { get; }
        decimal PencePerLitre { get; set; }
        string TransactionCostInPence { get; }
        decimal TransactionQuantity { get; }
    }
}
