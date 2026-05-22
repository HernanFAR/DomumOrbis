using CommonContext.Errors;
using CommonContext.Invariants.String;
using CommonContext.Literals;
using VSlices.Literals;

namespace CommonContext.Invariants.Checksum;

/// <summary>
/// Represents the EAN-13 checksum algorithm, which is used for calculating, formatting, 
/// and segmenting checksums for EAN-13 barcodes.
/// </summary>
/// <remarks>
/// The EAN-13 algorithm ensures that the provided payload adheres to the expected format 
/// and computes a checksum to validate the integrity of the data. It also provides 
/// functionality to format and segment EAN-13 barcode values.
/// </remarks>
public sealed class Ean13 : IChecksumAlgorithm
{
    /// <summary>
    /// Computes the checksum for the given payload using the EAN-13 algorithm.
    /// </summary>
    /// <param name="payload">
    /// The input string for which the checksum is to be computed. 
    /// Must be exactly 12 characters long and contain only digits.
    /// </param>
    /// <returns>
    /// A <see cref="Fin{T}"/> containing the computed <see cref="ChecksumParts"/> if the input is valid; 
    /// otherwise, an error indicating the validation failure.
    /// </returns>
    public static Fin<ChecksumParts> Compute(string payload) =>
        (
            ExactLength<N12>.Validate(payload, (r, v) => ExactLengthError.New(v, r.Length)),
            OnlyDigits.Validate(payload, OnlyDigitsError.New)
        )
        .Apply((_, _) => new ChecksumParts(payload, GetCheck(payload)))
        .As();

    /// <summary>
    /// Formats the specified <see cref="ChecksumParts"/> instance into a string representation
    /// by concatenating the payload and the checksum value.
    /// </summary>
    /// <param name="value">
    /// The <see cref="ChecksumParts"/> instance containing the payload and checksum to format.
    /// </param>
    /// <returns>
    /// A string representation of the EAN-13 checksum, consisting of the payload followed by the checksum value.
    /// </returns>
    public static string Format(ChecksumParts value) => 
        $"{value.Payload}{value.Check}";

    /// <summary>
    /// Segments a given 13-character string into its payload and checksum parts.
    /// </summary>
    /// <param name="value">
    /// The 13-character string to be segmented. The string must have exactly 13 characters.
    /// </param>
    /// <returns>
    /// A <see cref="Fin{T}"/> containing the segmented <see cref="ChecksumParts"/> if the input is valid; 
    /// otherwise, an error indicating the validation failure.
    /// </returns>
    /// <remarks>
    /// This method validates that the input string has exactly 13 characters. If the validation succeeds, 
    /// it splits the string into the payload (first 12 characters) and the checksum (last character).
    /// </remarks>
    public static Fin<ChecksumParts> Segment(string value) =>
        (
            ExactLength<N13>.Validate(value, (r, v) => ExactLengthError.New(v, r.Length)),
            OnlyDigits.Validate(value, OnlyDigitsError.New)
        )
        .Apply((_, _) => new ChecksumParts(value[..^1], value[^1..]))
        .As();

    private static string GetCheck(string payload)
    {
        var sum = 0;

        for (var i = 0; i < payload.Length; i++)
        {
            var digit = payload[i] - '0';

            // EAN-13:
            // odd positions ×1
            // even positions ×3
            var weight = (i % 2 == 0)
                ? 1
                : 3;

            sum += digit * weight;
        }

        var remainder = sum % 10;

        var checkDigit = remainder == 0
            ? 0
            : 10 - remainder;

        return checkDigit.ToString();
    }
}
