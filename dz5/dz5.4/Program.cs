/* Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, 
среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.
 */
Console.WriteLine("Введите размер массива");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[arraySize];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Случайный массив: ");
PrintArray(numbers);

int max = numbers.Max();
int indexMax = Array.IndexOf(numbers, max);
int min = numbers.Min();
int indexMin = Array.IndexOf(numbers, min);

int arraySum = 0;

for (int i = 0; i < numbers.Length; i++)
    arraySum += numbers[i];

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-99, 99);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("");
    Console.WriteLine();
}


