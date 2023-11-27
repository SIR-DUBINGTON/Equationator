using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equationator
{
    public partial class MathAreaRectangle : IFormula
    {
        private double b;
        private double h;
        private double a;

        public MathAreaRectangle(double b, double h, double a)
        {
            this.b = b;
            this.h = h;
            this.a = a;
        }

        public double Calculate()
        {
            Console.WriteLine($"Breadth: {b}, Height: {h}");
            double a = b * h;
            Console.WriteLine($"Result: {a}");
            return a;
        }

        public double CalculateTerm2()
        {
            Console.WriteLine($"Area: {a}, Height: {h}");
            double b = a / h;
            Console.WriteLine($"Result: {b}");
            return b;
        }

        public double CalculateTerm3()
        {
            Console.WriteLine($"Area: {a}, Breadth: {b}");
            double h = a / b;
            Console.WriteLine($"Result: {h}");
            return h;
        }


        public string GetFormula()
        {
            return "a = b * h";
        }

        public string GetFormulaTerm2()
        {
            return "b = a / h";
        }

        public string GetFormulaTerm3()
        {
            return "h = a / b";
        }

        public double CalculateTerm4()
        {
            throw new NotImplementedException();
        }
    }

}
