namespace CommonContext.Invariants.Checksum;

/// <summary>
/// Represents a domain rule for validating checksum values using a specified checksum algorithm.
/// </summary>
/// <typeparam name="ALGO">
/// The type of the checksum algorithm used for validation. Must implement <see cref="IChecksumAlgorithm"/>.
/// </typeparam>
public sealed class ChecksumRule<ALGO> : Rule<ChecksumRule<ALGO>, string>
    where ALGO : IChecksumAlgorithm
{
    /// <summary>
    /// Validates the provided string value by checking its checksum against the computed checksum
    /// using the specified checksum algorithm.
    /// </summary>
    /// <param name="value">
    /// The input string to validate. It must conform to the format and rules defined by the checksum algorithm.
    /// </param>
    /// <returns>
    /// <c>true</c> if the checksum of the input string matches the computed checksum; otherwise, <c>false</c>.
    /// </returns>
    public static bool Check(string value) =>
        (
            from sentParts in ALGO.Segment(value)
            from computedParts in ALGO.Compute(sentParts.Payload)
            select computedParts.Check == sentParts.Check
        )
        .IfFail(false);
}