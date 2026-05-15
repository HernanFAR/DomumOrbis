using LanguageExt.Traits;

namespace CommonContext.ValueObjects;

public sealed record TextError(int Min,
    int Max,
    int Current,
    string Value)
    : Expected(string.Empty, 0);

public sealed class Text<Min, Max> : DomainType<Text<Min, Max>, string>
    where Min : Const<int>
    where Max : Const<int>
{
    private readonly string _value;

    public static int MinLength => Min.Value;

    public static int MaxLength => Max.Value;

    private Text(string value) => _value = value;

    public override string ToString() => _value.Trim();

    public static Fin<Text<Min, Max>> From(string repr)
    {
        repr = repr.Trim();

        Fin<Unit> minLength = repr.Length < MinLength || repr.Length > MaxLength
            ? new TextError(Min.Value, Max.Value, repr.Length, repr)
            : unit;

        return minLength.Map(_ => new Text<Min, Max>(repr));
    }

    public string To() => _value.Trim();
}
