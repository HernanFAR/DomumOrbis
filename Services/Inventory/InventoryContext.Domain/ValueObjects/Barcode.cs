using CommonContext.Invariants.Checksum;
using CommonContext.ValueObjects;

namespace InventoryContext.ValueObjects;

public sealed class Barcode : 
    DerivedTypeFactory<Barcode, ChecksumString<Ean13>, ChecksumParts>,
    DomainFactory<Barcode, string>
{
    private readonly ChecksumString<Ean13> _value;

    private Barcode(ChecksumString<Ean13> value) =>
        _value = value;

    public ChecksumString<Ean13> ToBase() => _value;

    public override string ToString() => $"{_value}";
    
    public ChecksumParts To() => _value.To();

    public static Barcode New(ChecksumString<Ean13> @base) =>
        new(@base);

    public static Fin<Barcode> From(string repr) =>
        ChecksumString<Ean13>.From(repr).Map(New);
}
