/*  Задача HARD SORT необязательная. Считается за три обязательных
Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
Например, задан массив:
1 4 7 2
5 9 10 3
После сортировки
1 2 3 4
5 7 9 10  */

/*  void SelectionSort(int[] array)                    //метод упорядочивания массива
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)      //ищем минимальный элемент в неотсортированной части
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];           //после выполнения действий выше надо поменять вначале заданную i на ту, кот.нашли temporary
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}  */
//int[] arr = new int[9];

/* Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали  и отдельно сумму элементов обратной диагонали.
Например, задан массив:
1 4 7 
5 9 2 
8 4 2 
Сумма элементов главной диагонали: 1+9+2 = 12
Сумма элементов обратной диагонали: 8+9+7 = 24 */
void Method2(int[,] array)
{
    int sum1 = 0;
    int sum2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++) 
        if (i == j)
        {
            sum1 = sum1 + array[i, j];
        }
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++) 
        if (i + j == array.GetLength(0) - 1)
        {
            sum2 = sum2 + array[i, j];
        }    
    Console.WriteLine($"Сумма элементов главной диагонали:{sum1}");
    Console.WriteLine($"Сумма элементов обратной диагонали:{sum2}");
}
/* void Method(int[,] array)
{
    for (int i = 1; i < array.GetLength(0); i += 2)
        for (int j = 1; j < array.GetLength(1); j += 2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
} */

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 11);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3} \t");
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
/* Method(array); */
Console.WriteLine();
PrintArray(array);
Method2(array);

/* Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4 */