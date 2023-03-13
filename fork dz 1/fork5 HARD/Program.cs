Console.Write("Введите любое число(p.s. Лучше более 9) ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);

if (num >= 10)
{
    while (num > 99)
    {
        num = num /10;
    }
    int result = num % 10;
    Console.Write(result);
}
else
{
    Console.Write("Введенное число меньше даже не двухзначное");
}