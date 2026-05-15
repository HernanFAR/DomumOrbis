using CommonContext.ValueObjects.Dimensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CommonContext.ValueObjects.MeasureUnits;


public interface MeasureUnit<Unit, Dim>
    where Unit : MeasureUnit<Unit, Dim>
    where Dim : Dimension
{
    static abstract string Name { get; }
    
    static abstract string Symbol { get; }

    static abstract decimal FactorToBase { get; }

    static decimal ToBase(decimal value) => value * Unit.FactorToBase;

    static decimal FromBase(decimal baseValue) => baseValue / Unit.FactorToBase;
}

public sealed class Gram : MeasureUnit<Gram, Weight>, Const<Gram>
{
    private Gram() { }

    public static string Name => "Gramo";

    public static string Symbol => "G";

    public static decimal FactorToBase => 1m;

    public static Gram Value => new();
}

public sealed class Ton : MeasureUnit<Ton, Weight>, Const<Ton>
{
    private Ton() { }

    public static string Name => "Tonelada";

    public static string Symbol => "T";

    public static decimal FactorToBase => 1_000_000;

    public static Ton Value => new();
}

public sealed class Liter : MeasureUnit<Liter, Volumen>
{
    private Liter() { }

    public static string Name => "Litro";
    public static string Symbol => "L";
    public static decimal FactorToBase => 1m;

}

public sealed class Piece : MeasureUnit<Piece, Count>
{
    private Piece() { }

    public static string Name => "Unidad";
    public static string Symbol => "U";
    public static decimal FactorToBase => 1m;

}