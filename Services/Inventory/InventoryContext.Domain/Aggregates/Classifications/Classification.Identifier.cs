using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryContext.Aggregates.Classifications;

public sealed class ClassificationId
    : DomainType<ClassificationId, string>,
      Identifier<ClassificationId>
{
    public const string IdIsNotValid =
        $"El identificador generado no es valido para {nameof(ClassificationId)}";

    private readonly string _value;

    public static ClassificationId Default { get; } = new(Guid.Empty.ToString());

    private ClassificationId(string value) => _value = value;

    public override string ToString() => _value;

    public bool Equals(ClassificationId? other) => _value == other?._value;

    public string To() => _value;

    public override bool Equals(object? obj) =>
        ReferenceEquals(this, obj) ||
        obj is ClassificationId other && Equals(other);

    public override int GetHashCode() =>
        _value.GetHashCode();

    public static Fin<ClassificationId> From(string value) =>
        Guid.TryParse(value, out Guid _)
            ? new ClassificationId(value)
            : Error.New(IdIsNotValid);

    public static bool operator ==(ClassificationId? left, ClassificationId? right)
    {
        if (left is null) return right is null;

        return left.Equals(right);
    }

    public static bool operator !=(ClassificationId? left, ClassificationId? right) =>
        !(left == right);
}
