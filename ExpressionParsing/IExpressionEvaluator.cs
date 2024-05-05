using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.ExpressionParsing
{
    // Interface for expression evaluation
    public interface IExpressionEvaluator
    {
        int Evaluate(string postfix);
    }
}
