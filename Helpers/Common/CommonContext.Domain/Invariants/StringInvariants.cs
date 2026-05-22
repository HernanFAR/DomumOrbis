using System;
using System.Collections.Generic;
using System.Text;

namespace CommonContext.Invariants.String;

public sealed class MaxLength<L> : Rule<MaxLength<L>, string>
    where L : Const<int>
{
    public int Limit { get; } = L.Value;

    public static bool Check(string value) =>
        value.Length <= L.Value;
}

public sealed class NonEmptyStr : Rule<NonEmptyStr, string>
{
    public static bool Check(string value) =>
        value.Length != 0;
}

public sealed class ExactLength<L> : Rule<ExactLength<L>, string>
    where L : Const<int>
{
    public int Length { get; } = L.Value;

    public static bool Check(string value) =>
        value.Length == L.Value;
}

public sealed class OnlyDigits : Rule<OnlyDigits, string>
{
    public static bool Check(string value) => 
        value.All(char.IsDigit);
}

public sealed class GuidLike : Rule<GuidLike, string>
{
    public static bool Check(string value) =>
        Guid.TryParse(value, out _);
}