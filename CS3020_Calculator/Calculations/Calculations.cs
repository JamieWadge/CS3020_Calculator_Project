using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3020_Calculator.Calculations
{
    public interface Calculation
    {
        public double Calculate(double Num1, double Num2);
    }

    public class Addition : Calculation
    {
        public double Calculate(double Num1, double Num2)
        {
            return Num1 + Num2;
        }
    }

    public class Subtraction : Calculation
    {
        public double Calculate(double Num1, double Num2)
        {
            return Num1 - Num2;
        }
    }

    public class Multiplication : Calculation
    {
        public double Calculate(double Num1, double Num2)
        {
            return Num1 * Num2;
        }
    }

    public class Division : Calculation
    {
        public double Calculate(double Num1, double Num2)
        {
            if (Num2 == 0)
            {
                throw new DivideByZeroException("You cannot divide by zero\n");
            }
            return Num1 / Num2;
        }
    }

    public class Percentage : Calculation
    {
        public double Calculate(double Num1, double Num2)
        {
            if (Num2 == 0)
            {
                throw new DivideByZeroException("You cannot get percentage of zero\n");
            }
            return (Num1 / Num2) * 100;
        }
    }
}
