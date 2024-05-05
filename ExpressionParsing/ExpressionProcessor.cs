using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.ExpressionParsing
{
    public class ExpressionProcessor
    {
        private readonly IExpressionConverter _converter;
        private readonly IExpressionEvaluator _evaluator;

        public ExpressionProcessor(IExpressionConverter converter, IExpressionEvaluator evaluator)
        {
            _converter = converter;
            _evaluator = evaluator;
        }

        public int Process(string infix)
        {
            string postfix = _converter.Convert(infix);
            return _evaluator.Evaluate(postfix);
        }
    }
}
