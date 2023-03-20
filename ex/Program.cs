string[] SampleThreeChar(string[] array)
{
    string result = String.Empty;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result += array[i] + "separator";
        }
    }
    return result.Split("separator", StringSplitOptions.RemoveEmptyEntries);
}

void PrintArray(string[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

string[] array1 = new string[] { "hello", "2", "world", ":-)" };
string[] array2 = new string[] { "1234", "1567", "-2", "computer science" };
string[] array3 = new string[] { "Russia", "Denmark", "Kazan" };

PrintArray(SampleThreeChar(array1));
PrintArray(SampleThreeChar(array2));
PrintArray(SampleThreeChar(array3));

