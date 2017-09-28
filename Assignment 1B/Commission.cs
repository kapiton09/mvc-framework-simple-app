using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Assignment_1B
{
    [Serializable()]
    class Commission : Person
    {
        //Attributes for salary Employee only
        private double salesPercent;
        private double totalSales;
        private double totalPay;

        // Constructor
        public Commission(string salaryName, int salaryMobile, string salaryType, string salaryGender, double percent, double totalsale, int x_at, int y_at) 
			: base(salaryName, salaryMobile, salaryType, salaryGender, x_at, y_at)
		{
            salesPercent = percent;
            totalSales = totalsale;
            //Calculating Total pay
            totalPay = (percent / 100) * totalsale;
        }

        // Override method to display salary as text
        public override string ToString()
        {
            return "Employee Type: " + personType + ", Name: " + personName + ", Mobile: " + personMobile + ", Sales %: " + salesPercent + ", Total Sales: " + totalSales + ", Total pay: $" + totalPay + this.Position();
        }

        // Override method to display shape as graphic
        public override void Display(Graphics g)
        {
            if (g != null)
            {
                string path;

                if (genderMale.Equals("Male"))
                {
                    path = "../../resources/salesman.png"; // Gender: Male
                }
                else
                    path = "../../resources/saleswoman.png"; // Gender: Female


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

        public double sales_percent
        {
            get
            {
                return salesPercent;
            }
            set
            {
                salesPercent = value;
            }
        }

        public double total_sales
        {
            get
            {
                return totalSales;
            }
            set
            {
                totalSales = value;
            }
        }

        //Method to calculate total pay
        public override double calculatePay()
        {
            totalPay = (salesPercent /100 ) * totalSales;
            return totalPay;
        }

        /// <summary>method: HitTest
        /// used to create ellipse the same size as the shape if selected
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