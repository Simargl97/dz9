/* string Method4(int count, string c)
{
    
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
string  res = Method4(10, "12");
Console.WriteLine(res); */

/* Таблица Умножения!!!

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
} */

int[] arr = { 1, 5, 4, 6, 3, 5, 2, 3 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{ array[ i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray( arr);
SelectionSort( arr);

PrintArray( arr);