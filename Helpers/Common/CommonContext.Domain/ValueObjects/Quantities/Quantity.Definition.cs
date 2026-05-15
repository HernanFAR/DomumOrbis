using CommonContext.Domain.ValueObjects;
using CommonContext.ValueObjects.Dimensions;
using CommonContext.ValueObjects.MeasureUnits;
using LanguageExt.Traits;
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
    public Numeric<Num, Min, Max> Value { get; }

    public Unit Metric { get; }

    private Quantity(Numeric<Num, Min, Max> value, Unit metric) =>
        (Value, Metric) = (value, metric);

    public static Fin<Quantity<Num, Min, Max, Dim, Unit>> From(Num value, Unit metric) =>
        Numeric<Num, Min, Max>.From(value)
            .Map(n => new Quantity<Num, Min, Max, Dim, Unit>(n, metric));
}
