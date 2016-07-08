using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingTask
{
    public class Triangle
    {
        readonly int Equilateral = 1;
        readonly int Isosceles = 2;
        readonly int Scalene = 3;

        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public bool CheckTriangle()
        {
            if (A <= 0)
            {
                return false;
            }

            if (B <= 0)
            {
                return false;
            }

            if (C <= 0)
            {
                return false;
            }

            if (A + B <= C)
            {
                return false;
            }

            if (A + C <= B)
            {
                return false;
            }

            if (B + C <= A)
            {
                return false;
            }

            return true;
        }

        public int DetectTriangle()
        {
            if (!CheckTriangle())
            {
                return 0;
            }

            if (A == B && B == C && A == C)
            {
                return Equilateral; 
            }

            if (A == B || B == C || A == C)
            {
                return Isosceles;
            }

            return Scalene;
        }

        public double GetSquare()
        {
            double p,s2;
            p = (A + B + C) / 2;
            s2 = p * (p - A) * (p - B) * (p - C);
            if (s2 < 0)
            {
                throw new ArithmeticException();
            }
            return Math.Sqrt(s2);
        }
    }
}
