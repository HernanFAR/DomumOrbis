using CommonContext.ValueObjects.Dimensions;
using CommonContext.ValueObjects.MeasureUnits;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CommonContext.ValueObjects.Quantities;

public sealed partial class Quantity<Num, Min, Max, Dim, Unit> 
    where Num : INumber<Num>
    where Min : Const<Num>
    where Max : Const<Num>
    where Dim : Dimension
    where Unit : MeasureUnit<Unit, Dim>
{
    public bool Equals(Quantity<Num, Min, Max, Dim, Unit>? other) =>
        other is not null && this.Value.Equals(other.Value);

    public Fin<Quantity<Num, Min, Max, Dim, ToUnit>> Transform<ToUnit>()
        where ToUnit : MeasureUnit<Unit, Dim>
    {
        var ownBaseValue = Num.CreateChecked(Unit.FactorToBase);
        var otherBaseValue = Num.CreateChecked(ToUnit.FactorToBase);
    }

    public Fin<Quantity<Num, Min, Max, Dim, Unit>> Add(Quantity<Num, Min, Max, Dim, Unit> other)
    {
        if (other is null) throw new ArgumentNullException(nameof(other));
        if (!this.Metric.GetType().Equals(other.Metric.GetType()))
            throw new InvalidOperationException("Cannot add quantities with different metrics.");
        Num sum = this.Value.To() + other.Value.To();

        return From(sum, this.Metric);
    }

    public Quantity<Num, Min, Max, Dim, Unit> AddUnsafe(Quantity<Num, Min, Max, Dim, Unit> other) =>
        Add(other).ThrowOrDebugIfFail();

    public Fin<Quantity<Num, Min, Max, Dim, Unit>> Subtract(Quantity<Num, Min, Max, Dim, Unit> other)
    {
        ArgumentNullException.ThrowIfNull(other);

        Num difference = this.Value.To() - other.Value.To();

        return From(difference, this.Metric);
    }

    public Quantity<Num, Min, Max, Dim, Unit> SubtractUnsafe(Quantity<Num, Min, Max, Dim, Unit> other) =>
        Subtract(other).ThrowOrDebugIfFail();

}
