using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Assignment_1B
{
    public partial class ViewForm3 : Form, IPersonView
    {
        private PersonsModel myModel;

        public ViewForm3()
        {
            InitializeComponent();
            cmbFilterDisplay.SelectedIndex = 0;
        }

        // set value for myModel
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
            // clear drawOn panel
            clearPanel();
            // create arrayList from model and convert to array of Persons
            ArrayList thePersonList = myModel.PersonList;
            Person[] thePersons = (Person[])thePersonList.ToArray(typeof(Person));
            Graphics g = this.pnlDrawOn.CreateGraphics();
            // draw all Persons in array
            foreach (Person sh in thePersons)
            {
                sh.Display(g);
            }
        }

        /// <summary>method: clearPanel
		/// clear all Persons from display on panel
		/// </summary>
		private void clearPanel()
        {
            pnlDrawOn.CreateGraphics().Clear(pnlDrawOn.BackColor);
        }

        /// <summary>method: DisplayWage
		/// display Wage earner only
		/// </summary>
		public void DisplayWage()
        {
            // clear panel
            clearPanel();
            // create arraylist of person from model
            // to array of Persons
            ArrayList thePersonList = myModel.PersonList;
            Person[] thePersons = (Person[])thePersonList.ToArray(typeof(Person));
            // graphics object to draw Persons
            Graphics g = this.pnlDrawOn.CreateGraphics();

            foreach (Person sh in thePersons)
            {
                // redraw Wage only
                if (sh.person_type.Equals("Wage"))
                    sh.Display(g);
            }
        }

        /// <summary>method: DisplaySalary
        /// display Salary earner only
        /// </summary>
        public void DisplaySalary()
        {
            // clear panel
            clearPanel();
            // create arraylist of Persons from model 
            // to array of Persons
            ArrayList thePersonList = myModel.PersonList;
            Person[] thePersons = (Person[])thePersonList.ToArray(typeof(Person));
            // graphics object to draw Persons
            Graphics g = this.pnlDrawOn.CreateGraphics();

            foreach (Person sh in thePersons)
            {
                // only draw Salary
                if (sh.person_type.Equals("Salary"))
                    sh.Display(g);
            }
        }

        /// <summary>method: DisplayCommission
        ///  display Commission earner only
        /// </summary>
        public void DisplayCommission()
        {
            // clear panel
            clearPanel();
            // create arraylist of Persons from model
            // to array of Persons
            ArrayList thePersonList = myModel.PersonList;
            Person[] thePersons = (Person[])thePersonList.ToArray(typeof(Person));
            // graphics object to draw Persons
            Graphics g = this.pnlDrawOn.CreateGraphics();

            foreach (Person sh in thePersons)
            {
                // only draw Commission
                if (sh.person_type.Equals("Commission"))
                    sh.Display(g);
            }
        }

        private void cmbFilterDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display Clear Panel
            if (cmbFilterDisplay.SelectedIndex == -1 || cmbFilterDisplay.SelectedIndex == 0)
                clearPanel();
            // Display All Employee
            else if (cmbFilterDisplay.SelectedIndex == 1)
                RefreshView();
            //Display Wage earner only
            else if (cmbFilterDisplay.SelectedIndex == 2)
                DisplayWage();
            //Display Salary earner only
            else if (cmbFilterDisplay.SelectedIndex == 3)
                DisplaySalary();
            //Display Commission earner only
            else if (cmbFilterDisplay.SelectedIndex == 4)
                DisplayCommission();
        }
    }
}
