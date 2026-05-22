namespace CommonContext.Invariants.Checksum;

public sealed record ChecksumParts(string Payload, string Check)
{
    public string Payload { get; } = Payload;
    
    public string Check { get; } = Check;

    public override string ToString() =>
        $"Payload: {Payload}, Check: {Check}";
}

/// <summary>
/// Represents an algorithm for calculating and validating checksums.
/// </summary>
public interface IChecksumAlgorithm
{
    /// <summary>
    /// Computes the checksum for the given payload using the algorithm's rules.
    /// </summary>
    /// <param name="payload">
    /// The input string for which the checksum needs to be computed. 
    /// It must adhere to the specific rules of the algorithm, such as length or character constraints.
    /// </param>
    /// <returns>
    /// A <see cref="Fin{T}"/> containing a <see cref="ChecksumParts"/> instance with the computed payload and checksum,
    /// or an error if the input payload is invalid according to the algorithm's rules.
    /// </returns>
    static abstract Fin<ChecksumParts> Compute(string payload);

    /// <summary>
    /// Formats the specified <see cref="ChecksumParts"/> instance into a string representation
    /// according to the rules of the checksum algorithm.
    /// </summary>
    /// <param name="value">
    /// The <see cref="ChecksumParts"/> instance containing the payload and checksum to be formatted.
    /// </param>
    /// <returns>
    /// A string representation of the <see cref="ChecksumParts"/> instance, formatted according to
    /// the algorithm's rules.
    /// </returns>
    static abstract string Format(ChecksumParts value);

    /// <summary>
    /// Segments the provided string into its payload and checksum components
    /// according to the rules of the checksum algorithm.
    /// </summary>
    /// <param name="value">
    /// The input string to be segmented. It must conform to the specific format
    /// required by the algorithm, such as length or character constraints.
    /// </param>
    /// <returns>
    /// A <see cref="Fin{T}"/> containing a <see cref="ChecksumParts"/> instance
    /// with the segmented payload and checksum, or an error if the input string
    /// does not meet the algorithm's requirements.
    /// </returns>
    static abstract Fin<ChecksumParts> Segment(string value);
}
