using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Calc.__Circumfrence_and_area___Lab_10
{
    class Circle
    {
        private double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }


        public double CalculateCircumference()
        {
           return 2 * Math.PI * Radius;
        }
        //public string CalculateFormattedCircumference()
        //{
            
        //}
        public double CalculateArea()
        {
            return Math.PI * (2 * Radius);
        }
        //public string CalculateFomattedArea()
        //{

        //}
        //private string FormattedNumber(double x)
        //{

        //}
    }
}
