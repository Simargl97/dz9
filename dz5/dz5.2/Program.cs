/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
 */
Console.WriteLine("Введите размер массива");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[arraySize];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int sum = 0;

for (int i = 0; i < numbers.Length; i+=2)
{
        sum = numbers[i] + sum;
}

Console.WriteLine($"Всего {numbers.Length} числа, сумма чисел на нечетных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-99, 99);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write(" ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("");
    Console.WriteLine();
}