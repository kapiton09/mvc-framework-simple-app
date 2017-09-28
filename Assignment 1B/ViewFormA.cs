using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1B
{
    public partial class ViewForm2 : Form, IPersonView
    {
        private PersonsModel myModel;

        bool dragging;
        Person topPerson; //  variable for selected Person
        Person editPerson; // variable for Person to edit

        // variables for max values of parameters input by user
        int max_X = 725;
        int max_Y = 325;

        // variables for mouse position
        Point lastPosition = new Point(0, 0);
        Point currentPosition = new Point(0, 0);

        public ViewForm2()
        {
            InitializeComponent();
            listBox1.ContextMenu = this.contextMenu1;
        }


        // set method for myModel
        public PersonsModel MyModel
        {
            set
            {
                myModel = value;
            }
        }

        /// <summary> method: RefreshView
		/// clears the listBox displays all the Persons in the PersonsModel
		/// </summary>
		public void RefreshView()
        {
            // clear listBox
            listBox1.Items.Clear();
            // create arrayList from model and convert to array of Persons
            ArrayList thePersonList = myModel.PersonList;
            Person[] thePersons = (Person[])thePersonList.ToArray(typeof(Person));
            Graphics g = this.pnlDrawOn.CreateGraphics();
            // draw all Persons in array
            foreach (Person sh in thePersons)
            {
                listBox1.Items.Add(sh.ToString());
            }
        }

        /// <summary>method: isInputValid
		/// method to check user input is valid
		/// </summary>
		/// <param name="txtXpos"></param>
		/// <param name="txtYpos"></param>
		/// <param name="txtHeight"></param>
		/// <returns></returns>
		private bool InputValid(string txtXpos, string txtYpos)
        {

            int X, Y;
            bool validInput = false;
            // required fields populated 

            // convert user inputs to variables				
            X = Convert.ToInt32(txtXpos);
            Y = Convert.ToInt32(txtYpos);

            // validate data entry is within limits
            if ((X > max_X) || (Y > max_Y))
            {
                MessageBox.Show("Maximum value for X is " + max_X
                    + "\r\n" + "Maximum value for Y is " + max_Y + "\r\n",
                    "Please Check the Values Entered",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                validInput = false;
            }
            else
            {
                validInput = true;
            }
            return validInput;
        }

        //Method to Clear the whole form
        public void clearInput()
        {
            txtXpos.Text = "";
            txtYpos.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtHourlyRate.Text = "";
            txtHoursWorked.Text = "";
            txtPackage.Text = "";
            txtSalesPer.Text = "";
            txtTotalSales.Text = "";
            cbxGender.SelectedIndex = -1;
            lblHourlyRate.Enabled = true;
            lblHoursWorked.Enabled = true;
            txtHourlyRate.Enabled = true;
            txtHoursWorked.Enabled = true;
            lblPackage.Enabled = true;
            txtPackage.Enabled = true;
            lblSales.Enabled = true;
            lblTotalSales.Enabled = true;
            txtSalesPer.Enabled = true;
            txtTotalSales.Enabled = true;
            rbCommission.Checked = false;
            rbSalary.Checked = false;
            rbWage.Checked = false;
        }

        /// <summary> method: btnAddPerson_Click
		/// adds person to model based on parameters entered by user
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            // variables required for Person object
            int X, Y, phone ;
            string personName, type, gender;
            Person aPerson;
            double rate, hours, package, salesPercent, totalSales;

            bool validInput = false;

            try
            {
                //  check all fields populated
                if ((txtXpos.Text.ToString() == "") ||
                    (txtYpos.Text.ToString() == ""))

                    // display error message
                    MessageBox.Show
                        ("Please enter Position", "Required Data Missing",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (txtName.Text.ToString() == "" || txtPhone.Text.ToString() == "" || cbxGender.SelectedIndex == -1)
                {
                    MessageBox.Show("Please input personal details!", "Required Data Missing",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // fields populated, if valid input create Person
                    validInput = InputValid(txtXpos.Text.ToString(), txtYpos.Text.ToString());

                    if (validInput)
                    {
                        X = Convert.ToInt32(txtXpos.Text);
                        Y = Convert.ToInt32(txtYpos.Text);
                        personName = txtName.Text.ToString();
                        phone = Convert.ToInt32(txtPhone.Text);
                        gender = cbxGender.SelectedItem.ToString();
                        //Checking if Person type is selected or not
                        if (rbWage.Checked == false && rbSalary.Checked == false && rbCommission.Checked == false)
                        {
                            MessageBox.Show("Please check employee type!", "Required Type Missing",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        //for Wage earner
                        if (rbWage.Checked)
                        {
                            if (txtHourlyRate.Text.ToString() == "" || txtHoursWorked.Text.ToString() == "")
                            {
                                MessageBox.Show("Please input hours and rate details!", "Required Data Missing",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                type = "Wage";
                                rate = Convert.ToDouble(txtHourlyRate.Text);
                                hours = Convert.ToDouble(txtHoursWorked.Text);
                                aPerson = new Wage(personName, phone, type, gender, rate, hours, X, Y);
                                myModel.AddPerson(aPerson);
                                clearInput();
                            }
                        }
                        //For Salary earner
                        if (rbSalary.Checked)
                        {
                            if (txtPackage.Text.ToString() == "")
                            {
                                MessageBox.Show("Please input package", "Required Data Missing",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                type = "Salary";
                                package = Convert.ToDouble(txtPackage.Text);
                                aPerson = new Salary(personName, phone, type, gender, package, X, Y);
                                myModel.AddPerson(aPerson);
                                clearInput();
                            }
                        }
                        //For Commission earner
                        if (rbCommission.Checked)
                        {
                            if (txtSalesPer.Text.ToString() == "" || txtTotalSales.Text.ToString() == "")
                            {
                                MessageBox.Show("Please input sales details!", "Required Data Missing",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            if (Convert.ToDecimal(txtSalesPer.Text.ToString()) <= 0 || Convert.ToDecimal(txtSalesPer.Text.ToString()) > 99)
                            {
                                MessageBox.Show("Sales commission percent must be between 0 and 99% !", "Required Data Missing",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                type = "Commission";
                                salesPercent = Convert.ToDouble(txtSalesPer.Text);
                                totalSales = Convert.ToDouble(txtTotalSales.Text);
                                aPerson = new Commission(personName, phone, type, gender, salesPercent, totalSales, X, Y);
                                myModel.AddPerson(aPerson);
                                clearInput();
                            }
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input number field in correct format!", "Incorrect Data Format",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + "\r\n" + ex.ToString(),
                    "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>method: btnClearInput_Click
        /// clear user input fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearInput_Click(object sender, System.EventArgs e)
        {
            clearInput();
        }

        /// <summary>method: clearPanel
        /// clear all Persons from display on panel
        /// </summary>
        private void clearPanel()
        {
            pnlDrawOn.CreateGraphics().Clear(pnlDrawOn.BackColor);
        }


        //Method to update selected person
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // clear draw on panel
            clearPanel();

            // local variables for updates to selected person
            string name, gender;
            int phone;

            if (txtUpdateName.Text.ToString() == "" || txtUpdatePhone.Text.ToString() == "" || cbxUpdateGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please input personal details!", "Required Data Missing",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // get updated attributes for selected person
                name = txtUpdateName.Text.ToString();
                phone = Convert.ToInt32(txtUpdatePhone.Text);
                gender = cbxUpdateGender.SelectedItem.ToString();

                // update Person attributes
                editPerson.person_name = name;
                editPerson.person_mobile = phone;
                editPerson.Gender = gender;
                // redisplay
                myModel.UpdateViews();
                pnlUpdate.Hide();
                cbxUpdateGender.SelectedIndex = -1;
            }
        }

        /// <summary>method: btnCancel_Click
        /// hide the update panel without updating Person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlUpdate.Hide();
        }

        //Method to enable wage field and disable others
        private void rbWage_Click(object sender, EventArgs e)
        {
            lblHourlyRate.Enabled = true;
            lblHoursWorked.Enabled = true;
            txtHourlyRate.Enabled = true;
            txtHoursWorked.Enabled = true;
            lblPackage.Enabled = false;
            txtPackage.Enabled = false;
            lblSales.Enabled = false;
            lblTotalSales.Enabled = false;
            txtSalesPer.Enabled = false;
            txtTotalSales.Enabled = false;
        }

        //Method to enable salary field and disable others
        private void rbSalary_Click(object sender, EventArgs e)
        {
            lblPackage.Enabled = true;
            txtPackage.Enabled = true;
            lblHourlyRate.Enabled = false;
            lblHoursWorked.Enabled = false;
            txtHourlyRate.Enabled = false;
            txtHoursWorked.Enabled = false;
            lblSales.Enabled = false;
            lblTotalSales.Enabled = false;
            txtSalesPer.Enabled = false;
            txtTotalSales.Enabled = false;
        }

        //Method to enable commission field and disable others
        private void rbCommission_Click(object sender, EventArgs e)
        {
            lblHourlyRate.Enabled = false;
            lblHoursWorked.Enabled = false;
            txtHourlyRate.Enabled = false;
            txtHoursWorked.Enabled = false;
            lblPackage.Enabled = false;
            txtPackage.Enabled = false;
            lblSales.Enabled = true;
            lblTotalSales.Enabled = true;
            txtSalesPer.Enabled = true;
            txtTotalSales.Enabled = true;
        }

        /// <summary>method: editToolStripMenuItem_Click
        /// Displays the update panel and prompts the user to 
        /// enter new values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuEdit_Click(object sender, EventArgs e)
        {
            if (topPerson != null)
            {
                // message to user to enter new size and colour
                MessageBox.Show("You May Update Personal details Only" + "\r\n",
                    "Enter new values and click the Update button",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // make editPerson the current topPerson 
                editPerson = topPerson;

                // update values in update panel to selected Person
                lblSelectedPerson.Text = topPerson.ToString();
                txtUpdateName.Text = topPerson.person_name.ToString();
                txtUpdatePhone.Text = topPerson.person_mobile.ToString();

                // show update panel
                pnlUpdate.Show();
                //myModel.UpdateViews();
            }
            myModel.UpdateViews();
        }

        /// <summary>method: mnuDelete_Click
        /// delete selected Person and redisplay Persons remaiing in model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuDelete_Click(object sender, System.EventArgs e)
        {
            // check is topPerson has a value, if so delete
            if (topPerson != null)
            {
                // clear panel
                clearPanel();
                // delete selected person and redisplay remaining person
                myModel.DeletePerson(topPerson);
            }
            myModel.UpdateViews();
        }

        /// <summary> method: mnuCancel_Click
        /// do nothing when user selects cancel menu option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuCancel_Click(object sender, System.EventArgs e)
        {
            // refresh view
            myModel.UpdateViews();
        }

        /// <summary>method: reDisplay
		/// redraws all the Persons in the model
		/// </summary>
		public void reDisplay()
        {
            ArrayList thePersonList = myModel.PersonList;
            Person[] thePersons = (Person[])thePersonList.ToArray(typeof(Person));
            Graphics g = this.pnlDrawOn.CreateGraphics();
            foreach (Person sh in thePersons)
            {
                sh.Display(g);
            }
        }

        /// <summary>method: CheckForNumeric
		/// check for only numbers and backspace key
		/// </summary>
		/// <param name="ch"></param>
		/// <returns></returns>
		static bool CheckForNumeric(char ch)
        {
            int keyInt = (int)ch;
            if ((keyInt < 48 || keyInt > 57) && keyInt != 8)
                return false;
            else
                return true;
        }

        /// <summary> method: txtXpos_KeyPress
		/// allow only numbers and backspace key
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtXpos_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (CheckForNumeric(e.KeyChar) == false)
                e.Handled = true;
        }
    }
}
