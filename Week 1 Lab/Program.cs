Console.WriteLine("Welcome to the Caesar Cipher Program!");
Console.WriteLine("By Joshua Eagles (301078033) and Muhammad Ilyas Sameer Ismail (301168447)\n");

Console.WriteLine("Are you encoding or decoding?");
Console.WriteLine("e - encoding");
Console.WriteLine("d - decoding");
bool isEncoding = (Console.ReadLine() ?? "") == "e";

Console.WriteLine($"\nInput the string to {((isEncoding) ? "encode" : "decode")}.");
string inputString = Console.ReadLine()?.ToLower() ?? "";

Console.WriteLine("\nInput the cipher key.");
int cipherKey = int.Parse(Console.ReadLine() ?? "0");

if (isEncoding)
{
    string encodedInput = encode(inputString, cipherKey);
    Console.WriteLine($"The encoded string is {encodedInput}");
}
else
{
    string decodedInput = decode(inputString, cipherKey);
    Console.WriteLine($"The decoded string is {decodedInput}");
}

static string encode(string inputString, int cipherKey)
{
    return caesarTransform(inputString, cipherKey);
}

static string decode(string inputString, int cipherKey)
{
    return caesarTransform(inputString, -cipherKey);
}

static string caesarTransform(string inputString, int cipherKey)
{
    char[] transformedLetters = inputString.Select((char character) =>
        {
            // Bring the letters into the range of 0 to 25 so we can use modulo
            char normalizedChar = (char) (character - 'a');

            // Add the cipher key and modulo 26 to get the new letters with the wrap around effect
            char transformedNormalizedChar = (char) mod(normalizedChar + cipherKey, 26);

            // Add back the 'a' we removed earlier to bring this back into the proper range
            return (char) (transformedNormalizedChar + 'a');
        }).ToArray();

    return string.Join("", transformedLetters);
}

// C# % operator is remainder rather than modulo, this function gives us modulo behavior for dealing with negatives
static double mod(double a, double b)
{
    return a - b * Math.Floor(a / b);
}
