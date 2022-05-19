namespace PumpViewer
{
    partial class PumpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTransactionCost = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPricePerLitre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPumpState = new System.Windows.Forms.Label();
            this.lblPumpStateDescription = new System.Windows.Forms.Label();
            this.btnDispense = new System.Windows.Forms.Button();
            this.btnLift = new System.Windows.Forms.Button();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTransactionCost);
            this.panel1.Controls.Add(this.lblCost);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Controls.Add(this.lblPricePerLitre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblPumpState);
            this.panel1.Controls.Add(this.lblPumpStateDescription);
            this.panel1.Controls.Add(this.btnDispense);
            this.panel1.Controls.Add(this.btnLift);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 198);
            this.panel1.TabIndex = 0;
            // 
            // lblTransactionCost
            // 
            this.lblTransactionCost.AutoSize = true;
            this.lblTransactionCost.Location = new System.Drawing.Point(242, 160);
            this.lblTransactionCost.Name = "lblTransactionCost";
            this.lblTransactionCost.Size = new System.Drawing.Size(35, 13);
            this.lblTransactionCost.TabIndex = 12;
            this.lblTransactionCost.Text = "label4";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(236, 160);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(0, 13);
            this.lblCost.TabIndex = 11;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(249, 115);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(0, 13);
            this.lblQuantity.TabIndex = 10;
            // 
            // lblPricePerLitre
            // 
            this.lblPricePerLitre.AutoSize = true;
            this.lblPricePerLitre.Location = new System.Drawing.Point(236, 70);
            this.lblPricePerLitre.Name = "lblPricePerLitre";
            this.lblPricePerLitre.Size = new System.Drawing.Size(13, 13);
            this.lblPricePerLitre.TabIndex = 9;
            this.lblPricePerLitre.Text = "£";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Price per Litre:";
            // 
            // lblPumpState
            // 
            this.lblPumpState.AutoSize = true;
            this.lblPumpState.Location = new System.Drawing.Point(236, 28);
            this.lblPumpState.Name = "lblPumpState";
            this.lblPumpState.Size = new System.Drawing.Size(0, 13);
            this.lblPumpState.TabIndex = 5;
            // 
            // lblPumpStateDescription
            // 
            this.lblPumpStateDescription.AutoSize = true;
            this.lblPumpStateDescription.Location = new System.Drawing.Point(153, 28);
            this.lblPumpStateDescription.Name = "lblPumpStateDescription";
            this.lblPumpStateDescription.Size = new System.Drawing.Size(68, 13);
            this.lblPumpStateDescription.TabIndex = 4;
            this.lblPumpStateDescription.Text = "Pump State: ";
            // 
            // btnDispense
            // 
            this.btnDispense.Location = new System.Drawing.Point(0, 57);
            this.btnDispense.Name = "btnDispense";
            this.btnDispense.Size = new System.Drawing.Size(144, 38);
            this.btnDispense.TabIndex = 1;
            this.btnDispense.Text = "Dispense";
            this.btnDispense.UseVisualStyleBackColor = true;
            this.btnDispense.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDispense_MouseDown);
            this.btnDispense.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDispense_MouseUp);
            // 
            // btnLift
            // 
            this.btnLift.Location = new System.Drawing.Point(3, 3);
            this.btnLift.Name = "btnLift";
            this.btnLift.Size = new System.Drawing.Size(144, 38);
            this.btnLift.TabIndex = 0;
            this.btnLift.Text = "Lift Nozzle";
            this.btnLift.UseVisualStyleBackColor = true;
            this.btnLift.Click += new System.EventHandler(this.btnLift_Click);
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(15, 216);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(518, 20);
            this.tbStatus.TabIndex = 1;
            // 
            // PumpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 588);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.panel1);
            this.Name = "PumpForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PumpForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPumpState;
        private System.Windows.Forms.Label lblPumpStateDescription;
        private System.Windows.Forms.Button btnDispense;
        private System.Windows.Forms.Button btnLift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPricePerLitre;
        private System.Windows.Forms.Label lblTransactionCost;
        private System.Windows.Forms.TextBox tbStatus;
    }
}

