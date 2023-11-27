using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equationator
{
    public partial class PhysicsFormulaKineticEnergy : IFormula
    {
        private readonly double ke;
        private readonly double m;
        private readonly double v;
        
        public PhysicsFormulaKineticEnergy(double ke, double v, double m)
        {
            this.ke = ke;
            this.m = m;
            this.v = v;
        }
        public double Calculate()
        {
            Console.WriteLine($"Mass: {m}, Velocity: {v}");
            double ke = m * Math.Pow(v, 2) / 2;
            Console.WriteLine($"Result: {ke}");
            return ke;
        }

        public double CalculateTerm2()
        {
            Console.WriteLine($"Kinetic Energy: {ke}, Velocity: {v}");
            double m = (2 * ke) / (Math.Pow(v, 2));
            Console.WriteLine($"Result: {m}");
            return m;
        }
        public double CalculateTerm3()
        {
            Console.WriteLine($"Kinetic Energy: {ke}, Mass: {m}");
            double v = Math.Sqrt((2 * ke) / m);
            Console.WriteLine($"Result: {v}");
            return v;
        }

        public double CalculateTerm4()
        {
            return 0;
        }
        public string GetFormula()
        {
            return "KE = (m * v^2) / 2";
        }

        public string GetFormulaTerm2()
        {
            return "m = (2 * KE) / (v^2)";
        }

        public string GetFormulaTerm3()
        {
            return "v = sqrt((2 * KE) / m)";
        }
    }
    
}