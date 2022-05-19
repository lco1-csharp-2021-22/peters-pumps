using PumpLogic;
using System;
using System.Windows.Forms;

namespace PumpViewer
{
    // todo segments?  
    // todo images? 
    // todo add an update function to the main screen to update periodically, not just when dispensing stops with mouse up 
    public partial class PumpForm : Form
    {
        Pump _pump;

        public PumpForm()
        {
            InitializeComponent();
        }

        private void PumpForm_Load(object sender, EventArgs e)
        {

            _pump = new Pump(160.9m, 0.5m); // todo: load in the default from a config file 

            lblTransactionCost.DataBindings.Add("Text", _pump, "TransactionCostInPence");
            btnDispense.Enabled = false;
            btnLift.Enabled = true;
        }

        #region button clicks 

        private void btnLift_Click(object sender, EventArgs e)
        {
            switch(_pump.CurrentPumpState)
            {
                case(PumpState.Holstered):
                    btnLift.Text = "Replace Nozzle";
                    btnLift.Enabled = true;
                    btnDispense.Enabled = true;
                    _pump.LiftNozzle();
                    // todo: save the transaction somewhere - a database?  
                    break;
                case PumpState.Dispensing:
                    throw new PumpException("you shouldn't be able to click this if dispensing");
                case PumpState.JustUnholstered:
                    btnLift.Text = "Lift Nozzle";
                    btnLift.Enabled = true;
                    btnDispense.Enabled = false;
                    _pump.ReplaceNozzle();
                    break;
            }
        }               

        private void btnDispense_MouseDown(object sender, MouseEventArgs e)
        {
            btnLift.Enabled=false;
            _pump.StartDispensing(); 
            UpdateLabels();
        }

        private void btnDispense_MouseUp(object sender, MouseEventArgs e)
        {
            btnLift.Enabled = true;
            _pump.StopDispensing();
            UpdateLabels();
        }

        #endregion

        void UpdateLabels()
        {
            lblPumpState.Text = _pump.CurrentPumpState.ToString();
            lblPricePerLitre.Text = $"£{(_pump.PencePerLitre / 100).ToString("0.000")}";
            // lblCost.Text = _cost;
            lblQuantity.Text = $"{_pump.TransactionQuantity}";
            tbStatus.Text = _pump.ToString();
        }
    }
}
