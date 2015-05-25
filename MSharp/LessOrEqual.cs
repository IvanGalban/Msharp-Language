﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSharp
{
    public class LessOrEqual : RelationalComposite
    {
        public LessOrEqual() { }

        public LessOrEqual(FunctionArithmetic left, FunctionArithmetic right) : base(left, right) { }

        public override bool Evaluate(float x)
        {
            return (left.Evaluate(x) <= right.Evaluate(x)) ? true : false;
        }

        public override string ToText
        {
            get { return "<="; }
        }
    }
}
