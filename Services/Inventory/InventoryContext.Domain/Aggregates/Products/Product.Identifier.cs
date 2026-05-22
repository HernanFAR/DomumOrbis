namespace InventoryContext.Aggregates;

public sealed class ProductId : IdentifierType<ProductId, string>
{
    private readonly string _value;
    
    private ProductId(string value) =>
        _value = value;

    public static Fin<ProductId> From(string repr) =>
        GuidLike.Validate(repr, GuidLikeError.New)
            .Map(v => new ProductId(v));
    
    public string To() => _value;
    
    public override int GetHashCode() => _value.GetHashCode();

    public override bool Equals(object? obj)
    {
        if (obj is ProductId other)
        {
            return Equals(other);
        }

        return false;
    }
    public bool Equals(ProductId? other) => other is not null && _value == other._value;

    public static bool operator ==(ProductId? left, ProductId? right) => left?.Equals(right) ?? right is null;

    public static bool operator !=(ProductId? left, ProductId? right) => !(left == right);
}
