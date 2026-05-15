using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

public static class FinCommonContextExtensions
{
    extension<A>(Fin<A> ma)
    {
        public A ThrowOrDebugIfFail() 
        {
            Debug.Assert(ma.IsSucc, "Fin {ma} was not successful");

            return ma.ThrowIfFail();
        }
    }
}
