using LanguageExt.Traits;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CommonContext.Constants;

public sealed class Zero<T> : Const<T>
    where T : INumber<T>
{
    public static T Value => T.Zero;
}

public sealed class  One<T> : Const<T>
    where T : INumber<T>
{
    public static T Value => T.One;
}
