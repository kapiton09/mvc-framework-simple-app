using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Assignment_1B
{
    [Serializable()]
    class Wage : Person
    {
        //Attributes for Wage Employee only
        private double hourlyRate;
        private double Totalhours;
        private double totalPay;

        // constructor
        public Wage(string wageName, int wageMobile, string wageType, string wageGender, double rate, double hours, int x_at, int y_at) 
			: base(wageName, wageMobile, wageType, wageGender, x_at, y_at)
		{
            hourlyRate = rate;
            Totalhours = hours;
            //Calculating Total pay
            totalPay = rate * hours;
        }

        // override method to display Wage as text
        public override string ToString()
        {
            return "Employee Type: " + personType + ", Name: " + personName + ", Mobile: "+ personMobile + ", Hourly Rate: $" + hourlyRate + ", Hours " + Totalhours + ", Total pay: $"+ totalPay + this.Position();
        }

        // override method to display person as graphic
        public override void Display(Graphics g)
        {
            if (g != null)
            {
                string path;

                if (genderMale.Equals("Male"))
                {
                    path = "../../resources/wage-male.png";// Gender: Male
                }
                else
                    path = "../../resources/wage-female.png";// Gender: Female


                // Create image.
                Image newImage = Image.FromFile(@path);

                // Create Point for upper-left corner of image.
                Point ulCorner = new Point(x, y);

                // Draw image to screen.
                g.DrawImage(newImage, ulCorner);
            }
        }

        public override int x_pos //non abstract property
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public override int y_pos //non abstract property
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public override int person_mobile //non abstract property
        {
            get
            {
                return personMobile;
            }
            set
            {
                personMobile = value;
            }
        }

        public override string person_name //non abstract property
        {
            get
            {
                return personName;
            }
            set
            {
                personName = value;
            }
        }

        public override string person_type //non abstract property
        {
            get
            {
                return personType;
            }
            set
            {
                personType = value;
            }
        }

        public override string Gender //non abstract property
        {
            get
            {
                return genderMale;
            }
            set
            {
                genderMale = value;
            }
        }

        public double hourly_Rate
        {
            get
            {
                return hourlyRate;
            }
            set
            {
                hourlyRate = value;
            }
        }

        public double Total_hours
        {
            get
            {
                return Totalhours;
            }
            set
            {
                Totalhours = value;
            }
        }

        //Calculating Total pay
        public override double calculatePay()
        {
            totalPay = hourly_Rate * Total_hours;
            return totalPay;
        }


        /// <summary>method: HitTest
        /// used to create ellipse the same size as the person if selected
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public override bool HitTest(Point p)
        {
            GraphicsPath pth = new GraphicsPath();
           pth.AddEllipse(x, y, 50, 180);
            bool retval = pth.IsVisible(p);
            pth.Dispose();
            return retval;

        }

    }
}
