namespace Assignment_1B
{
    partial class ViewForm1
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
            this.components = new System.ComponentModel.Container();
            this.pnlDrawOn = new System.Windows.Forms.Panel();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtYpos = new System.Windows.Forms.TextBox();
            this.txtXpos = new System.Windows.Forms.TextBox();
            this.rbWage = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.rbSalary = new System.Windows.Forms.RadioButton();
            this.rbCommission = new System.Windows.Forms.RadioButton();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.cbxUpdateGender = new System.Windows.Forms.ComboBox();
            this.lblUpdateGender = new System.Windows.Forms.Label();
            this.lblSelectedPerson = new System.Windows.Forms.Label();
            this.txtUpdatePhone = new System.Windows.Forms.TextBox();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblGender = new System.Windows.Forms.Label();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.txtSalesPer = new System.Windows.Forms.TextBox();
            this.txtPackage = new System.Windows.Forms.TextBox();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.lblPackage = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.txtTotalSales = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.mnuEdit = new System.Windows.Forms.MenuItem();
            this.mnuDelete = new System.Windows.Forms.MenuItem();
            this.mnuFront = new System.Windows.Forms.MenuItem();
            this.mnuBack = new System.Windows.Forms.MenuItem();
            this.mnuCalcPay = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuCancel = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuOpen = new System.Windows.Forms.MenuItem();
            this.menuSave = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.mnuReset = new System.Windows.Forms.MenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDrawOn
            // 
            this.pnlDrawOn.BackColor = System.Drawing.Color.White;
            this.pnlDrawOn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrawOn.Location = new System.Drawing.Point(12, 12);
            this.pnlDrawOn.Name = "pnlDrawOn";
            this.pnlDrawOn.Size = new System.Drawing.Size(760, 380);
            this.pnlDrawOn.TabIndex = 21;
            this.pnlDrawOn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDrawOn__MouseDown);
            this.pnlDrawOn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDrawOn_MouseMove);
            this.pnlDrawOn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDrawOn__MouseUp);
            // 
            // btnClearInput
            // 
            this.btnClearInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearInput.Location = new System.Drawing.Point(483, 542);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(136, 32);
            this.btnClearInput.TabIndex = 32;
            this.btnClearInput.Text = "Clear Input";
            this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPerson.Location = new System.Drawing.Point(627, 542);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(136, 32);
            this.btnAddPerson.TabIndex = 31;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(12, 400);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(137, 24);
            this.lblDetails.TabIndex = 30;
            this.lblDetails.Text = "Personal Details";
            // 
            // txtYpos
            // 
            this.txtYpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYpos.Location = new System.Drawing.Point(153, 543);
            this.txtYpos.Name = "txtYpos";
            this.txtYpos.Size = new System.Drawing.Size(40, 26);
            this.txtYpos.TabIndex = 25;
            // 
            // txtXpos
            // 
            this.txtXpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXpos.Location = new System.Drawing.Point(63, 543);
            this.txtXpos.Name = "txtXpos";
            this.txtXpos.Size = new System.Drawing.Size(40, 26);
            this.txtXpos.TabIndex = 24;
            // 
            // rbWage
            // 
            this.rbWage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWage.Location = new System.Drawing.Point(252, 424);
            this.rbWage.Name = "rbWage";
            this.rbWage.Size = new System.Drawing.Size(104, 24);
            this.rbWage.TabIndex = 22;
            this.rbWage.Text = "Wage";
            this.rbWage.Click += new System.EventHandler(this.rbWage_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 545);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 546);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "X";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Screen Position";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(102, 456);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(91, 26);
            this.txtPhone.TabIndex = 34;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(102, 424);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(91, 26);
            this.txtName.TabIndex = 33;
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(12, 459);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(84, 24);
            this.lblPhone.TabIndex = 36;
            this.lblPhone.Text = "Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 427);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(84, 24);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rbSalary
            // 
            this.rbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSalary.Location = new System.Drawing.Point(252, 459);
            this.rbSalary.Name = "rbSalary";
            this.rbSalary.Size = new System.Drawing.Size(104, 24);
            this.rbSalary.TabIndex = 42;
            this.rbSalary.Text = "Salary";
            this.rbSalary.Click += new System.EventHandler(this.rbSalary_Click);
            // 
            // rbCommission
            // 
            this.rbCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCommission.Location = new System.Drawing.Point(252, 492);
            this.rbCommission.Name = "rbCommission";
            this.rbCommission.Size = new System.Drawing.Size(116, 24);
            this.rbCommission.TabIndex = 43;
            this.rbCommission.Text = "Commission";
            this.rbCommission.Click += new System.EventHandler(this.rbCommission_Click);
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlUpdate.Controls.Add(this.cbxUpdateGender);
            this.pnlUpdate.Controls.Add(this.lblUpdateGender);
            this.pnlUpdate.Controls.Add(this.lblSelectedPerson);
            this.pnlUpdate.Controls.Add(this.txtUpdatePhone);
            this.pnlUpdate.Controls.Add(this.txtUpdateName);
            this.pnlUpdate.Controls.Add(this.label6);
            this.pnlUpdate.Controls.Add(this.label8);
            this.pnlUpdate.Controls.Add(this.btnCancel);
            this.pnlUpdate.Controls.Add(this.btnUpdate);
            this.pnlUpdate.Controls.Add(this.label4);
            this.pnlUpdate.Location = new System.Drawing.Point(12, 399);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(760, 188);
            this.pnlUpdate.TabIndex = 44;
            this.pnlUpdate.Visible = false;
            // 
            // cbxUpdateGender
            // 
            this.cbxUpdateGender.FormattingEnabled = true;
            this.cbxUpdateGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxUpdateGender.Location = new System.Drawing.Point(102, 104);
            this.cbxUpdateGender.Name = "cbxUpdateGender";
            this.cbxUpdateGender.Size = new System.Drawing.Size(91, 21);
            this.cbxUpdateGender.TabIndex = 48;
            // 
            // lblUpdateGender
            // 
            this.lblUpdateGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateGender.Location = new System.Drawing.Point(12, 104);
            this.lblUpdateGender.Name = "lblUpdateGender";
            this.lblUpdateGender.Size = new System.Drawing.Size(79, 24);
            this.lblUpdateGender.TabIndex = 47;
            this.lblUpdateGender.Text = "Gender:";
            this.lblUpdateGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSelectedPerson
            // 
            this.lblSelectedPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedPerson.Location = new System.Drawing.Point(137, 13);
            this.lblSelectedPerson.Name = "lblSelectedPerson";
            this.lblSelectedPerson.Size = new System.Drawing.Size(472, 24);
            this.lblSelectedPerson.TabIndex = 45;
            this.lblSelectedPerson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUpdatePhone
            // 
            this.txtUpdatePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePhone.Location = new System.Drawing.Point(102, 72);
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.Size = new System.Drawing.Size(91, 26);
            this.txtUpdatePhone.TabIndex = 40;
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateName.Location = new System.Drawing.Point(102, 40);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(91, 26);
            this.txtUpdateName.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 42;
            this.label6.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 24);
            this.label8.TabIndex = 41;
            this.label8.Text = "Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(615, 96);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 32);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(454, 96);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 32);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update Person";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Details";
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(17, 486);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(79, 24);
            this.lblGender.TabIndex = 45;
            this.lblGender.Text = "Gender:";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxGender
            // 
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxGender.Location = new System.Drawing.Point(102, 488);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(91, 21);
            this.cbxGender.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(248, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 24);
            this.label7.TabIndex = 47;
            this.label7.Text = "Employee Type";
            // 
            // lblSales
            // 
            this.lblSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.Location = new System.Drawing.Point(362, 492);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(164, 24);
            this.lblSales.TabIndex = 53;
            this.lblSales.Text = "Sales %:";
            this.lblSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSalesPer
            // 
            this.txtSalesPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesPer.Location = new System.Drawing.Point(532, 493);
            this.txtSalesPer.Name = "txtSalesPer";
            this.txtSalesPer.Size = new System.Drawing.Size(61, 26);
            this.txtSalesPer.TabIndex = 52;
            // 
            // txtPackage
            // 
            this.txtPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackage.Location = new System.Drawing.Point(532, 459);
            this.txtPackage.Name = "txtPackage";
            this.txtPackage.Size = new System.Drawing.Size(127, 26);
            this.txtPackage.TabIndex = 49;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourlyRate.Location = new System.Drawing.Point(532, 427);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(61, 26);
            this.txtHourlyRate.TabIndex = 48;
            // 
            // lblPackage
            // 
            this.lblPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackage.Location = new System.Drawing.Point(362, 459);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(164, 24);
            this.lblPackage.TabIndex = 51;
            this.lblPackage.Text = "Package per annum";
            this.lblPackage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRate.Location = new System.Drawing.Point(362, 427);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(164, 24);
            this.lblHourlyRate.TabIndex = 50;
            this.lblHourlyRate.Text = "Hourly Rate:";
            this.lblHourlyRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.Location = new System.Drawing.Point(599, 493);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(104, 24);
            this.lblTotalSales.TabIndex = 57;
            this.lblTotalSales.Text = "Total Sales:";
            this.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSales.Location = new System.Drawing.Point(709, 494);
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.Size = new System.Drawing.Size(54, 26);
            this.txtTotalSales.TabIndex = 56;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoursWorked.Location = new System.Drawing.Point(709, 428);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(54, 26);
            this.txtHoursWorked.TabIndex = 54;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorked.Location = new System.Drawing.Point(599, 428);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(104, 24);
            this.lblHoursWorked.TabIndex = 55;
            this.lblHoursWorked.Text = "Hours worked:";
            this.lblHoursWorked.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuEdit,
            this.mnuDelete,
            this.mnuFront,
            this.mnuBack,
            this.mnuCalcPay,
            this.menuItem1,
            this.mnuCancel,
            this.menuItem2});
            // 
            // mnuEdit
            // 
            this.mnuEdit.Index = 0;
            this.mnuEdit.Text = "Edit";
            this.mnuEdit.Click += new System.EventHandler(this.mnuEdit_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Index = 1;
            this.mnuDelete.Text = "Delete";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // mnuFront
            // 
            this.mnuFront.Index = 2;
            this.mnuFront.Text = "Bring to Front";
            this.mnuFront.Click += new System.EventHandler(this.mnuFront_Click);
            // 
            // mnuBack
            // 
            this.mnuBack.Index = 3;
            this.mnuBack.Text = "Send to Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuCalcPay
            // 
            this.mnuCalcPay.Index = 4;
            this.mnuCalcPay.Text = "Calculate Pay";
            this.mnuCalcPay.Click += new System.EventHandler(this.mnuCalcPay_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 5;
            this.menuItem1.Text = "----------------";
            // 
            // mnuCancel
            // 
            this.mnuCancel.Index = 6;
            this.mnuCancel.Text = "Cancel";
            this.mnuCancel.Click += new System.EventHandler(this.mnuCancel_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 7;
            this.menuItem2.Text = "Refresh";
            this.menuItem2.Click += new System.EventHandler(this.mnuCancel_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3});
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuOpen,
            this.menuSave,
            this.menuItem5,
            this.mnuReset});
            this.menuItem3.Text = "File";
            // 
            // menuOpen
            // 
            this.menuOpen.Index = 0;
            this.menuOpen.Text = "Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuSave
            // 
            this.menuSave.Index = 1;
            this.menuSave.Text = "Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 2;
            this.menuItem5.Text = "-";
            // 
            // mnuReset
            // 
            this.mnuReset.Index = 3;
            this.mnuReset.Text = "Reset";
            this.mnuReset.Click += new System.EventHandler(this.mnuReset_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "dat";
            this.saveFileDialog1.FileName = "doc1";
            this.saveFileDialog1.Filter = "\"Dat files (*.dat)|*.dat|All files (*.*)|*.*\"";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "dat";
            this.openFileDialog1.Filter = "\"Dat files (*.dat)|*.dat|All files (*.*)|*.*\"";
            this.openFileDialog1.FilterIndex = 0;
            // 
            // ViewForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 597);
            this.Controls.Add(this.pnlUpdate);
            this.Controls.Add(this.lblTotalSales);
            this.Controls.Add(this.txtTotalSales);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.txtSalesPer);
            this.Controls.Add(this.txtPackage);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.lblPackage);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.rbCommission);
            this.Controls.Add(this.rbSalary);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pnlDrawOn);
            this.Controls.Add(this.btnClearInput);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtYpos);
            this.Controls.Add(this.txtXpos);
            this.Controls.Add(this.rbWage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "ViewForm1";
            this.Text = "Graphical View Form";
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrawOn;
        private System.Windows.Forms.Button btnClearInput;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtYpos;
        private System.Windows.Forms.TextBox txtXpos;
        private System.Windows.Forms.RadioButton rbWage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton rbSalary;
        private System.Windows.Forms.RadioButton rbCommission;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.TextBox txtUpdatePhone;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.TextBox txtSalesPer;
        private System.Windows.Forms.TextBox txtPackage;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.TextBox txtTotalSales;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblSelectedPerson;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem mnuEdit;
        private System.Windows.Forms.MenuItem mnuDelete;
        private System.Windows.Forms.MenuItem mnuFront;
        private System.Windows.Forms.MenuItem mnuBack;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem mnuCancel;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.ComboBox cbxUpdateGender;
        private System.Windows.Forms.Label lblUpdateGender;
        private System.Windows.Forms.MenuItem mnuCalcPay;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuOpen;
        private System.Windows.Forms.MenuItem menuSave;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuItem mnuReset;
    }
}