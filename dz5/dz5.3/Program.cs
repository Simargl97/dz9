/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
 */

Console.WriteLine("Введите размер массива");
int arraySize = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[arraySize];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Случайный массив: ");
PrintArray(numbers);

double max = numbers.Max();
int indexMax = Array.IndexOf(numbers, max);
double min = numbers.Min();
int indexMin = Array.IndexOf(numbers, min);

double sum = max - min;
double result = Math.Round(sum, 2);

Console.WriteLine ($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между {max} и {min} = {result}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("");
    Console.WriteLine();
}