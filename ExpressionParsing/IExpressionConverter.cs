using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.ExpressionParsing
{
    // Interface for expression conversion
    public interface IExpressionConverter
    {
        string Convert(string infix);
    }
}
