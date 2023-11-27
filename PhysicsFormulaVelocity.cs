using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equationator
{
    public partial class PhysicsFormulaVelocity : IFormula
    {
        private double v;
        private double u;
        private double t;
        private double a;
        
        public PhysicsFormulaVelocity(double u, double a, double t, double v)
        {
            this.v = v;
            this.u = u;
            this.t = t;
            this.a = a;
        }
        public double Calculate()
        {
            Console.WriteLine($"Initial Velocity: {u}, Acceleration: {a},Time: {t}");
            double v = (u) + (a * t);
            Console.WriteLine($"Result: {v}");
            return v;
        }

        public double CalculateTerm2()
        {
            Console.WriteLine($"Velocity: {v}, Acceleration: {a},Time: {t}");
            double u = -(a) * t + v;
            Console.WriteLine($"Result: {u}");
            return u;
        }
        public double CalculateTerm3()
        {
            Console.WriteLine($"Velocity: {v}, Initial Velocity: {u},Time: {t}");
            double a = (-u + v) / t;
            Console.WriteLine($"Result: {t}");
            return a;
        }

        public double CalculateTerm4()
        {
            Console.WriteLine($"Velocity: {v}, Initial Velocity: {u}, Acceleration: {a}");
            double t = (-u + v) / a;
            Console.WriteLine($"Result: {t}");
            return t;
        }
        public string GetFormula()
        {
            return "v = u + a * t";
        }

        public string GetFormulaTerm2()
        {
            return "u = -(a * t) + v";
        }

        public string GetFormulaTerm3()
        {
            return "a = -(u + v) / t";
        }

        public string GetFormulaTerm4()
        {
            return "t = -(u + v) / a";
        }
    }
}
