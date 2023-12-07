using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equationator
{
    public partial class MathAreaCircle : IFormula
    {
        private double r;
        private double A;

        public MathAreaCircle(double r, double A)
        {
            this.r = r;
            this.A = A;
        }

        public double Calculate()
        {
            Console.WriteLine($"Radius: {r}");
            double A = (Math.PI * Math.Pow(r, 2));
            Console.WriteLine($"Result: {A}");
            return A;
        }

        public double CalculateTerm2()
        {
            Console.WriteLine($"Area: {A}");
            double r = Math.Sqrt(A / Math.PI);
            Console.WriteLine($"Result: {r}");
            return r;
        }

        public double CalculateTerm3()
        {
            return 0;
        }

        public double CalculateTerm4()
        {
            return 0;
        }

        public string GetFormula()
        {
            return "A = πr²";
        }


    }
    
}
