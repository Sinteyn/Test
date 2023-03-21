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
    if(array.Length == 0) Console.Write("[]");
    else Console.Write("[{0}]", "\"" + string.Join("\", \"", array) + "\"");
}

string[] array1 = new string[] { "hello", "2", "world", ":-)" };
string[] array2 = new string[] { "1234", "1567", "-2", "computer science" };
string[] array3 = new string[] { "Russia", "Denmark", "Kazan" };

string[] result1 = SampleThreeChar(array1);
string[] result2 = SampleThreeChar(array2);
string[] result3 = SampleThreeChar(array3);

PrintArray(array1);
Console.Write(" --> ");
PrintArray(result1);
Console.WriteLine();
PrintArray(array2);
Console.Write(" --> ");
PrintArray(result2);
Console.WriteLine();
PrintArray(array3);
Console.Write(" --> ");
PrintArray(result3);
Console.WriteLine();