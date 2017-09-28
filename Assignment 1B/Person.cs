using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Assignment_1B
{
    /// <summary>
	/// Summary description for Person.
	/// </summary>
    /// 
    [Serializable()]
    public abstract class Person
    {
        protected string personName;
        protected int personMobile;
        protected string personType;
        protected int x;
        protected int y;
        protected string genderMale;

        // added for highlight
        bool highlight;

        // constructor
        public Person(string person, int mobile, string type, string male, int x_at, int y_at)
        {
            personName = person;
            personMobile = mobile;
            personType = type;
            x = x_at;
            y = y_at;
            genderMale = male;
        }

        public abstract void Display(Graphics g); // abstract method

        public abstract double calculatePay(); // abstract method

        public bool Highlight
        {
            get
            {
                return highlight;
            }
            set
            {
                highlight = value;
            }
        }

        public string Position()  //non abstract method
        {
            return "(" + x.ToString() + "," + y.ToString() + ")";
        }

        public abstract int x_pos //abstract property
        {
            get;
            set;
        }

        public abstract int y_pos //abstract property
        {
            get;
            set;
        }

        public abstract int person_mobile //abstract property
        {
            get;
            set;
        }

        public abstract string person_name //abstract property
        {
            get;
            set;
        }

        public abstract string person_type //abstract property
        {
            get;
            set;
        }

        public abstract string Gender //abstract property
        {
            get;
            set;
        }


        // virtual method
        public virtual bool HitTest(Point p)
        {
            Point pt = new Point(x, y);
            Size size = new Size(100, 100);
            //default behaviour
            return new Rectangle(pt, size).Contains(p);
        }

    }
}
