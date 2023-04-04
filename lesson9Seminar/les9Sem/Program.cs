// посчитаем сумму всех целых чисел от 1 до N, где N вводится 
//пользователем

int Summa(int num)
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
Console.WriteLine($"искомая сумма  рекурсией равна {SummaRec(num)}");
