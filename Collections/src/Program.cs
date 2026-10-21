namespace src;

public class Program
{
    static void Main(string[] args)
    {
        /// Test cases for IsValidEgyptianPhone
        Console.WriteLine("01012345678".IsValidEgyptianPhone()); // valid, starts with 010
        Console.WriteLine("+201512345678".IsValidEgyptianPhone());  // valid, starts with +20


        Console.WriteLine("01312345678".IsValidEgyptianPhone());   // invalid, 013 is not a valid prefix
        Console.WriteLine("0101234567".IsValidEgyptianPhone()); // invalid, only 10 digits
        Console.WriteLine("0101234567a".IsValidEgyptianPhone()); // invalid, contains a letter
        Console.WriteLine("201012345678".IsValidEgyptianPhone()); // invalid, starts with 2 instead of 0 or +20
        Console.WriteLine("+2001012345678".IsValidEgyptianPhone()); // invalid, starts with +20 but has an extra 0 after it


        /// Test cases for IsValidEgyptianNationalId
        Console.WriteLine("29901011234567".IsValidEgyptianNationalId()); // valid, starts with 2 and has 14 digits
        Console.WriteLine("19901011234567".IsValidEgyptianNationalId()); // invalid, starts with 1 instead of 2 or 3
        Console.WriteLine("2990101123456".IsValidEgyptianNationalId()); // invalid, only 13 digits
        Console.WriteLine("29901011234567\n".IsValidEgyptianNationalId()); // invalid, contains a newline character at the end
    }
}
