using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equationator
{
    public partial class FocalRatio : IFormula
    {
        private double f;
        private double D;
        private double N;

        public FocalRatio(double f, double D, double N)
        {
            this.f = f;
            this.D = D;
            this.N = N;
        }

        public double Calculate()
        {
            Console.WriteLine($"Focal Ratio: {f}, {D}");
            double N = f / D;
            Console.WriteLine($"Result: {N}");
            return N;
        }

        public double CalculateTerm2()
        {
            Console.WriteLine($"f: {N}, {D}");
            double f = N * D;
            Console.WriteLine($"Result: {f}");
            return f;
        }

        public double CalculateTerm3()
        {
            Console.WriteLine($"D: {f}, {N}");
            double D = f / N;
            Console.WriteLine($"Result: {D}");
            return D;
        }

        public double CalculateTerm4()
        {
            return 0;
        }

        public string GetFormula()
        {
            return "N = f / D";
        }
    }
}
