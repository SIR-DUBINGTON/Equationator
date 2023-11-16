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

        public double CalculateForm()
        {
            Console.WriteLine($"Force: {f}, Gravity: {g}");
            double m = f / g;
            Console.WriteLine($"Result: {m}");
            return m;
        }

        public string GetFormula()
        {
            return "F = m * g";
        }

        public string GetFormulaForm()
        {
            return "m = f / g";
        }
    }
}
