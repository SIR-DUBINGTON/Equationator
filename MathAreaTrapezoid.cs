using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equationator
{
    public partial class MathAreaTrapezoid : IFormula
    {
        private double b;
        private double h;
        private double w;
        private double A;

        public MathAreaTrapezoid(double b, double h, double w, double A)
        {
            this.b = b;
            this.h = h;
            this.w = w;
            this.A = A;
        }

        public double Calculate()
        {
            Console.WriteLine($"Breadth: {b}, Height: {h}, a: {w}");
            double A = ((b + w) / 2 * h);
            Console.WriteLine($"Result: {A}");
            return A;
        }

        public double CalculateTerm2()
        {
            Console.WriteLine($"Area: {A}, Height: {h}, a: {w}");
            double b = (2 * A) / (h + w);
            Console.WriteLine($"Result: {b}");
            return b;
        }

        public double CalculateTerm3()
        {
            Console.WriteLine($"Area: {A}, Breadth: {b}, a: {w}");
            double h = (2 * A) / (b + w);
            Console.WriteLine($"Result: {h}");
            return h;
        }

        public double CalculateTerm4()
        {
            Console.WriteLine($"Area: {A}, Breadth: {b}, Height: {h}");
            double a = (2 * A) / (b + h);
            Console.WriteLine($"Result: {w}");
            return w;
        }

        public string GetFormula()
        {
            return "A = ((b + a) * h) / 2";
        }

        public string GetFormulaTerm2()
        {
            return "b = (2 * A) / (h + a)";
        }

        public string GetFormulaTerm3()
        {
            return "h = (2 * A) / (b + a)";
        }

        public string GetFormulaTerm4()
        {
            return "a = (2 * A) / (b + h)";
        }
    }
}
