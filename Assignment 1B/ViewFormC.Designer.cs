namespace Assignment_1B
{
    partial class ViewForm3
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
            this.pnlDrawOn = new System.Windows.Forms.Panel();
            this.cmbFilterDisplay = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlDrawOn
            // 
            this.pnlDrawOn.BackColor = System.Drawing.Color.White;
            this.pnlDrawOn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrawOn.Location = new System.Drawing.Point(12, 12);
            this.pnlDrawOn.Name = "pnlDrawOn";
            this.pnlDrawOn.Size = new System.Drawing.Size(760, 380);
            this.pnlDrawOn.TabIndex = 22;
            // 
            // cmbFilterDisplay
            // 
            this.cmbFilterDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterDisplay.Items.AddRange(new object[] {
            "Select display.....",
            "All Employee",
            "Wage earner only",
            "Salary earner only",
            "Commission earner only"});
            this.cmbFilterDisplay.Location = new System.Drawing.Point(243, 414);
            this.cmbFilterDisplay.Name = "cmbFilterDisplay";
            this.cmbFilterDisplay.Size = new System.Drawing.Size(240, 28);
            this.cmbFilterDisplay.TabIndex = 23;
            this.cmbFilterDisplay.SelectedIndexChanged += new System.EventHandler(this.cmbFilterDisplay_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(155, 422);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(71, 13);
            this.lblFilter.TabIndex = 24;
            this.lblFilter.Text = "Filter view by:";
            // 
            // ViewForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 454);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cmbFilterDisplay);
            this.Controls.Add(this.pnlDrawOn);
            this.Name = "ViewForm3";
            this.Text = "Filter View Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawOn;
        private System.Windows.Forms.ComboBox cmbFilterDisplay;
        private System.Windows.Forms.Label lblFilter;
    }
}