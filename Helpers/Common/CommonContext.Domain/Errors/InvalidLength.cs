namespace CommonContext.Errors;

public sealed record MaxLengthError(string Value, int ExpectedLength)
    : Expected($"{Value} tiene más de {Value.Length} caracteres. Se esperaba {ExpectedLength}", 2)
{
    public int SentLength => Value.Length;

    public new static Error New(string value, int expectedLength) =>
        new MaxLengthError(value, expectedLength);
}

public sealed record ExactLengthError(string Value, int ExpectedLength)
    : Expected($"{Value} tiene {Value.Length} caracteres. Se esperaba {ExpectedLength}", 2)
{
    public int SentLength => Value.Length;

    public new static Error New(string value, int expectedLength) =>
        new ExactLengthError(value, expectedLength);
}

public sealed record OnlyDigitsError(string Value)
    : Expected($"{Value} debe contener solo digitos", 3)
{
    public new static Error New(string value) =>
        new OnlyDigitsError(value);
}

public sealed record GuidLikeError(string Value)
    : Expected($"{Value} no es un GUID válido", 4)
{
    public new static Error New(string value) =>
        new GuidLikeError(value);
}