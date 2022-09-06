Console.WriteLine("Welcome to the Caesar Cipher Program!");
Console.WriteLine("By Joshua Eagles (301078033) and ...\n");

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
            return (char)((character - 'a' + cipherKey) % 26 + 'a');
        }).ToArray();

    return string.Join("", transformedLetters);
}
