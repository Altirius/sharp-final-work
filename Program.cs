
string[] filterArray(string[] array)
{
	string[] buffer = new string[array.Length];
	int qty = 0;

	for (int i = 0; i < array.Length; i++)
		if (array[i].Length < 4)
			buffer[qty++] = array[i];

	string[] result = new string[qty];
	for (int i = 0; i < result.Length; i++)
		result[i] = buffer[i];

	return result;
}

void writeArray(string[] array)
{
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + ' ');
	Console.WriteLine();
}

void Main()
{
	string[] array = new string[] { "1dsfds0", "dkf", "12", "dkfjioff2", "233333", "_" };
	Console.Write("Initial array: ");
	writeArray(array);
	Console.Write("Result array: ");
	writeArray(filterArray(array));
}

Main();

