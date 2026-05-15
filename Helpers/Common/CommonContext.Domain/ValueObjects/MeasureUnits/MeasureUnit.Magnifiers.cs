using CommonContext.ValueObjects.Dimensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonContext.ValueObjects.MeasureUnits;

public sealed class Kilo<Unit, Dim> : MeasureUnit<Kilo<Unit, Dim>, Dim>, Const<Kilo<Unit, Dim>>
    where Unit : MeasureUnit<Kilo<Unit, Dim>, Dim>
    where Dim : Dimension
{
    public static Kilo<Unit, Dim> Value => new();

    public static string Name => "Kilo" + Unit.Name.ToLower();

    public static string Symbol => "k" + Unit.Symbol;

    public static decimal FactorToBase => Unit.FactorToBase * 1000;
}


public sealed class Mili<Unit, Dim> : MeasureUnit<Kilo<Unit, Dim>, Dim>, Const<Mili<Unit, Dim>>
    where Unit : MeasureUnit<Kilo<Unit, Dim>, Dim>
    where Dim : Dimension
{
    public static Mili<Unit, Dim> Value => new();

    public static string Name => "Mili" + Unit.Name.ToLower();

    public static string Symbol => "m" + Unit.Symbol;

    public static decimal FactorToBase => Unit.FactorToBase / 1000;
}
