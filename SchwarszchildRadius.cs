using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equationator
{
    public partial class SchwarszchildRadius : IFormula
    {
        private double r;
        private double G;
        private double M;
        private double c = 299792458;

        public SchwarszchildRadius(double r, double G, double M)
        {
            this.r = r;
            this.G = G;
            this.M = M;
        }

        public double Calculate()
        {
            Console.WriteLine($"Radius: {G}, {M}, {c}");
            double r = ((2) * (G) * (M)) / (Math.Pow(c, 2));
            Console.WriteLine($"Result: {r}");
            return r;
        }

        public double CalculateTerm2()
        {
            Console.WriteLine($"G: {r}, {c}, {M}");
            double G = (r * Math.Pow(c, 2)) / ((M) * (2));
            Console.WriteLine($"Result: {G}");
            return G;
        }

        public double CalculateTerm3()
        {
            Console.WriteLine($"M: {r}, {c}, {G}");
            double M = (r * Math.Pow(c, 2)) / ((G) * (2));
            Console.WriteLine($"Result: {M}");
            return M;
        }

        public double CalculateTerm4()
        {
            return 0;
        }

        public string GetFormula()
        {
            return "r = (2GM) / c²";
        }

    }
}
