using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Assignment_1B
{
    [Serializable()]
    class Salary : Person
    {
        //Attributes for Salary Employee only
        private double totalPackage;
        private double totalPay;

        // constructor
        public Salary(string salaryName, int salaryMobile, string salaryType, string salaryGender, double package, int x_at, int y_at) 
			: base(salaryName, salaryMobile, salaryType, salaryGender, x_at, y_at)
		{
            totalPackage = package;
            //Calculating Total pay per week
            totalPay = package / 52;
        }

        // override method to display salary employee as text
        public override string ToString()
        {
            return "Employee Type: " + personType + ", Name: " + personName + ", Mobile: " + personMobile + ", Package: $" + totalPackage + ", Total pay: $" + totalPay.ToString("f2") + " per week" + this.Position();
        }

        // override method to display shape as graphic
        public override void Display(Graphics g)
        {
            if (g != null)
            {
                string path;

                if (genderMale.Equals("Male"))
                {
                    path = "../../resources/salary-male.png"; // Gender: Male
                }
                else
                    path = "../../resources/salary-female.png"; // Gender: Female


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

        public double total_package
        {
            get
            {
                return totalPackage;
            }
            set
            {
                totalPackage = value;
            }
        }

        //Method to calculate total pay
        public override double calculatePay()
        {
            totalPay = total_package / 52;
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
