using VSlices.Literals;
using VSlices.Literals.Abstracts;

namespace CommonContext.Literals;


/// <summary>
/// Represents the number thirteen (13) as a strongly-typed constant.
/// </summary>
public sealed class N13 : N<int, N1, N3>
{
    /// <summary>
    /// Represents the number thirteen (13) as a strongly-typed constant of type <see cref="uint"/>.
    /// </summary>
    public sealed class U : N<uint, N1.U, N3.U>;

    /// <summary>
    /// Represents the number thirteen (13) as a strongly-typed constant of type <see cref="long"/>.
    /// </summary>
    public sealed class L : N<long, N1.L, N3.L>;

    /// <summary>
    /// Represents the number thirteen (13) as a strongly-typed constant of type <see cref="ulong"/>.
    /// </summary>
    public sealed class UL : N<ulong, N1.UL, N3.UL>;
}
