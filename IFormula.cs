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
        double CalculateForm();
        string GetFormula();

    }


}
