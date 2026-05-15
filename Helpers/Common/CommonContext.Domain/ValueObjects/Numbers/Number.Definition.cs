using System.Numerics;
using LanguageExt.Traits;

namespace CommonContext.Domain.ValueObjects;

public sealed record NumberError<Num>(
    Num MinValue, 
    Num MaxValue,
    Num Value)
    : Expected(string.Empty, 0);

public sealed class Numeric<Num, Min, Max> : DomainType<Numeric<Num, Min, Max>, Num>
    where Num : INumber<Num>
    where Min : Const<Num>
    where Max : Const<Num>
{
    public static Num MinValue => Min.Value;

    public static Num MaxValue => Max.Value;

    private readonly Num _value;

    private Numeric(Num value) => _value = value;

    public override string ToString() => _value?.ToString()?.Trim() ?? "";

    public Num To() => _value;

    public static Fin<Numeric<Num, Min, Max>> From(Num repr)
    {
        Fin<Unit> range = repr < MinValue || repr > MaxValue
            ? new NumberError<Num>(Min.Value, Max.Value, repr)
            : unit;

        return range.Map(_ => new Numeric<Num, Min, Max>(repr));
    }


    public static implicit operator Num(Numeric<Num, Min, Max> number) => number._value;

    public static explicit operator Numeric<Num, Min, Max>(Num value) => From(value).ThrowOrDebugIfFail();
}