using System.Text.RegularExpressions;

namespace src;

public static class StringValidationExtensions
{
    // Must be 11 digits, starting with 010, 011, 012, or 015
    private static readonly Regex PhonePattern = new(@"\A(?:0|\+20)1[0125][0-9]{8}\z");

    // Must be 14 digits, starting with 2 or 3
    private static readonly Regex NationalIdPattern = new(@"\A[23][0-9]{13}\z");

    public static bool IsValidEgyptianPhone(this string? value)
        => value is not null && PhonePattern.IsMatch(value);

    public static bool IsValidEgyptianNationalId(this string? value)
        => value is not null && NationalIdPattern.IsMatch(value);
}
