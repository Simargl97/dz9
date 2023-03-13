Console.WriteLine("Напишите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите второе число");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Напишите третье число");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("первое число max");
    }
    else
    {
        Console.WriteLine("третье число max");
    }
}
else 

if (b > c)
    {
        Console.WriteLine("второе число max");
    }
    else
    {
        Console.WriteLine("третье число max");
    }
