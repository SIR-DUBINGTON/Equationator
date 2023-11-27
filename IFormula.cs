using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equationator
{
    public interface IFormula
    {
        double Calculate();
        double CalculateTerm2();
        double CalculateTerm3();
        double CalculateTerm4();
        string GetFormula();

    }

}
