using System;
using System.Collections.Generic;
using System.Text;
using LanguageExt.Traits;

namespace CommonContext.Constants;

public sealed class I200 : Const<int>
{
    public static int Value => 200;
}

public sealed class IMax : Const<int>
{
    public static int Value => int.MaxValue;
}
