using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleProject.Models
{
    public class Rectangle
    {
        private double sideA;
        private double sideB;
        public double SideA
        {
            get { return this.sideA; }
            set
            {
                if (value <= 0)
                {
                    throw new ExcapctionRectangleSideIsNullOrZero();
                }
                this.sideA = value;
            }
        }
        public double SideB
        {
            get { return this.sideB; }
            set
            {
                if(value <= 0)
                {
                    throw new ExcapctionRectangleSideIsNullOrZero();
                }
                this.sideB = value;
            }
        }

        public Rectangle(double sideA, double sideB)
        {
            if(sideA <= 0 || sideB <= 0)
            {
                throw new ExcapctionRectangleSideIsNullOrZero();
            }
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public double Area
        {
            get { return this.sideA * this.sideB; }
        }

        public double Perimeter
        {
            get { return 2 * (this.sideA + this.sideB); }
        }

        public override string ToString()
        {
            return $"Téglalap a oldala: {this.sideA}, b oldala: {this.sideB}, területe: {Math.Round(this.Area, 2)} kerülete: {Math.Round(this.Perimeter, 2)}";
        }
    }
}
