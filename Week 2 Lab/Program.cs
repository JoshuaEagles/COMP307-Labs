Console.WriteLine("Welcome to the n+1 program.\nJoshua Eagles (301078033) & Son Roy Almerol ()");

while (true) {
	Console.Write("Please enter an integer: ");

	string inputStr = Console.ReadLine() ?? "";

	bool isSuccess = int.TryParse(inputStr, out int parsedInput);

	if (!isSuccess) 
	{
		Console.WriteLine($"{inputStr} is not a valid integer.");
	}
	else if (parsedInput >= int.MaxValue)
	{
		Console.WriteLine($"{parsedInput} is out of range.");
	}
	else 
	{
		Console.WriteLine($"{parsedInput} + 1 = {parsedInput + 1}");
		break;
	}
}