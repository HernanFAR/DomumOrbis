using LanguageExt.Traits;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CommonContext.Constants;


public sealed class MMax : Const<decimal>
{
    public static decimal Value => decimal.MaxValue;
}
