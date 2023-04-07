// посчитаем сумму всех целых чисел от 1 до N, где N вводится 
//пользователем

/* int Summa(int num)
{
    int sum = 0;
    while (true)
    {
        if (num == 0) break;
        sum = sum + num;
        num = num - 1;
    }
    return sum;
}

int SummaRec(int num)
{
    if (num == 0) return 0;
    return num + SummaRec(num - 1);
}

//SummaRec(5)
// 5 + ( 4 + (3 + (2 + (1 + 0))))


Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"искомая сумма равна {Summa(num)}");
Console.WriteLine($"искомая сумма  рекурсией равна {SummaRec(num)}"); */


/* Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные 
числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные 
числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8 */
PrintNumber1(5,10);

void PrintNumber(int n, int current = 1)
{
    if (current > n) return;

    Console.Write(current + " ");
    PrintNumber(n, current + 1);
}
                  
// PrintNumber(5);

void PrintNumber1(int n, int m)
{
    if (n > m) return;

    Console.Write(n + " ");
    PrintNumber1(n+1, m);
}

/* Задача 67: Напишите программу, которая будет принимать на вход число 
и возвращать сумму его цифр.
453 -> 12
45 -> 9
Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */