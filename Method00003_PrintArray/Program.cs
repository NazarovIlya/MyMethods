

void PrintArray(int[] array, string preOutputText, string postOutputText)
{
    Console.Write(preOutputText);
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}] ");
    }
    Console.WriteLine(postOutputText);
}