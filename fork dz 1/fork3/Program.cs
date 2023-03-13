Console.WriteLine("Введите число, а программа определит чётное ли оно");
double a = Convert.ToInt32(Console.ReadLine());
{
    if (a % 2 == 0)
    {
        Console.WriteLine("Число " + a +  " является: ЧЁТНЫМ ");
    }
    else
    {
        Console.WriteLine($"Число " + a +  " является: НЕЧЁТНЫМ ");
    }
}