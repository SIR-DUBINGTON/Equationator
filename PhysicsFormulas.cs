using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equationator
{
    public partial class PhysicsFormulas : IFormula
    {
        private double m;
        private double g;
        private double f;
        
        public PhysicsFormulas(double m, double g, double f)
        {
            this.m = m;
            this.g = g;
            this.f = f;
        }
        public double Calculate()
        {
            Console.WriteLine($"Mass: {m}, Gravity: {g}");
            double f = m * g;
            Console.WriteLine($"Result: {f}");
            return f;
        }

        public double CalculateTerm2()
        {
            Console.WriteLine($"Force: {f}, Gravity: {g}");
            double m = f / g;
            Console.WriteLine($"Result: {m}");
            return m;
        }
        public double CalculateTerm3()
        {
            Console.WriteLine($"Force: {f}, Mass: {m}");
            double g = f / m;
            Console.WriteLine($"Result: {g}");
            return g;
        }

        public double CalculateTerm4()
        {
            return 0;
        }
        public string GetFormula()
        {
            return "F = m * g";
        }

        public string GetFormulaTerm2()
        {
            return "m = F / g";
        }

        public string GetFormulaTerm3()
        {
            return "g = F / m";
        }
    }
}
