using System;
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
    public partial class MainForm : Form
    {
        private PersonsModel theModel;
        private PersonsController theController;
        private ViewForm1 myViewForm1;
        private ViewForm2 myViewForm2;
        private ViewForm3 myViewForm3;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMakeController_Click(object sender, EventArgs e)
        {
            theController = new PersonsController();
        }

        private void btnMakeModel_Click(object sender, EventArgs e)
        {
            theModel = new PersonsModel(theController);
        }

        private void btnMakeViews_Click(object sender, EventArgs e)
        {
            myViewForm1 = new ViewForm1();
            myViewForm2 = new ViewForm2();
            myViewForm3 = new ViewForm3();
            myViewForm1.MyModel = theModel;
            myViewForm2.MyModel = theModel;
            myViewForm3.MyModel = theModel;
            theController.AddView(myViewForm1);
            theController.AddView(myViewForm2);
            theController.AddView(myViewForm3);
        }

        private void btnShowViews_Click(object sender, EventArgs e)
        {
            myViewForm1.Show();
            myViewForm2.Show();
            myViewForm3.Show();
        }

        /// <summary>method: completeSetUp
		/// make controller
		/// make model
		/// make views and 
		/// show views
		/// </summary>
		private void completeSetUp()
        {
            // make controller
            theController = new PersonsController();
            // make model
            theModel = new PersonsModel(theController);
            // make views
            myViewForm1 = new ViewForm1();
            myViewForm2 = new ViewForm2();
            myViewForm3 = new ViewForm3();
            myViewForm1.MyModel = theModel;
            myViewForm2.MyModel = theModel;
            myViewForm3.MyModel = theModel;

            theController.AddView(myViewForm1);
            theController.AddView(myViewForm2);
            theController.AddView(myViewForm3);

            //show views
            myViewForm3.Show();
            myViewForm2.Show();
            myViewForm1.Show();
        }

        /// <summary> method: Form1_Load
        /// executes completeSetUp method when form loads to 
        /// make controller
        /// make model
        /// make views and 
        /// show views
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, System.EventArgs e)
        {
            completeSetUp();
        }
    }
}
