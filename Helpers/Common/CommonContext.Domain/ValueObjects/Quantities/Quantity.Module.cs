using CommonContext.ValueObjects.Dimensions;
using CommonContext.ValueObjects.MeasureUnits;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommonContext.ValueObjects.Quantities;

public static class Quantity
{
    public static Quantity<decimal, Zero<decimal>, MMax, Weight, Mili<Gram, Weight>> MiliGrams(decimal value) =>
        Quantity<decimal, Zero<decimal>, MMax, Weight, Mili<Gram, Weight>>.From(value, Mili<Gram, Weight>.Value).ThrowOrDebugIfFail();

    public static Quantity<decimal, Zero<decimal>, MMax, Weight, Gram> Grams(decimal value) =>
        Quantity<decimal, Zero<decimal>, MMax, Weight, Gram>.From(value, Gram.Value).ThrowOrDebugIfFail();

    public static Quantity<decimal, Zero<decimal>, MMax, Weight, Kilo<Gram, Weight>> Kilograms(decimal value) =>
        Quantity<decimal, Zero<decimal>, MMax, Weight, Kilo<Gram, Weight>>.From(value, Kilo<Gram, Weight>.Value).ThrowOrDebugIfFail();

}
