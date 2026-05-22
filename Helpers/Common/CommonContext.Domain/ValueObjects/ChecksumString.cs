using CommonContext.Invariants.Checksum;
namespace CommonContext.ValueObjects;

public sealed record InvalidCheckSum(string Value) : Expected("InvalidChecksum", 1)
{
    public static Error New(string value) => new InvalidCheckSum(value);
}

/// <summary>
/// Represents a strongly-typed checksum string that is validated and formatted using a specified checksum algorithm.
/// </summary>
/// <typeparam name="ALGO">
/// The type of the checksum algorithm used for validation and formatting. 
/// Must implement the <see cref="IChecksumAlgorithm"/> interface.
/// </typeparam>
public sealed class ChecksumString<ALGO> 
    : DomainTypeFactory<ChecksumString<ALGO>, ChecksumParts>,
      DomainFactory<ChecksumString<ALGO>, string> 
    where ALGO : IChecksumAlgorithm
{
    private readonly ChecksumParts _repr;
    
    private ChecksumString(ChecksumParts parts) => 
        _repr = parts;

    /// <summary>
    /// Converts the current instance of <see cref="ChecksumString{ALGO}"/> to its string representation.
    /// </summary>
    /// <returns>
    /// A string representation of the current <see cref="ChecksumString{ALGO}"/> instance, formatted
    /// using the specified checksum algorithm <typeparamref name="ALGO"/>.
    /// </returns>
    public override string ToString() =>
        ALGO.Format(_repr);

    /// <summary>
    /// Converts the current <see cref="ChecksumString{ALGO}"/> instance to its underlying representation.
    /// </summary>
    /// <returns>
    /// The <see cref="ChecksumParts"/> representation of the current <see cref="ChecksumString{ALGO}"/>.
    /// </returns>
    public ChecksumParts To() => _repr;

    /// <summary>
    /// Creates a new instance of <see cref="ChecksumString{ALGO}"/> from the provided <see cref="ChecksumParts"/> representation.
    /// </summary>
    /// <param name="repr">The <see cref="ChecksumParts"/> representation containing the payload and checksum.</param>
    /// <returns>
    /// A <see cref="Fin{T}"/> containing the successfully created <see cref="ChecksumString{ALGO}"/> instance
    /// if the validation succeeds, or an error if the validation fails.
    /// </returns>
    public static Fin<ChecksumString<ALGO>> From(ChecksumParts repr) =>
        ChecksumRule<ALGO>.Validate(ALGO.Format(repr), InvalidCheckSum.New)
            .Map(_ => new ChecksumString<ALGO>(repr));

    /// <summary>
    /// Creates a new instance of <see cref="ChecksumString{ALGO}"/> from the provided string representation.
    /// </summary>
    /// <param name="repr">
    /// The string representation of the checksum to be parsed and validated.
    /// </param>
    /// <returns>
    /// A <see cref="Fin{T}"/> containing the successfully created <see cref="ChecksumString{ALGO}"/> instance
    /// if the input is valid, or an error if validation fails.
    /// </returns>
    /// <remarks>
    /// This method uses the algorithm defined by <typeparamref name="ALGO"/> to segment and validate
    /// the input string representation before constructing the checksum object.
    /// </remarks>
    public static Fin<ChecksumString<ALGO>> From(string repr) =>
        ALGO.Segment(repr).Bind(From);
}
