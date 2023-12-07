using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equationator
{
    public partial class Redshift : IFormula
    {
        private double z;
        private double c = 299792458;
        private double v;

        public Redshift(double z, double v)
        {
            this.z = z;
            this.v = v;
        }

        public double Calculate()
        {
            Console.WriteLine($"Redshift: {v}, {c}");
            double z = v / c;
            Console.WriteLine($"Result: {v}");
            return z;
        }

        public double CalculateTerm2()
        {
            Console.WriteLine($"z: {z}, {c}");
            double v = z * c;
            Console.WriteLine($"Result: {z}");
            return v;
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
            return "v = z * c";
        }
    }
}
