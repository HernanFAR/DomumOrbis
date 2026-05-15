using CommonContext.Traits;

namespace InventoryContext.Aggregates.Classifications;

public sealed record Classification(ClassificationId Id, Text<I1, I200> Name) 
    : DomainEntity<Classification, ClassificationId>
{
    public static Classification New(ClassificationId id, Text<I1, I200> name) =>
        new(id, name);
}
