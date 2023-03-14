// Задача №17. Напишите программу, которая 
//принимает на вход координаты точки (X и Y),
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

using System;

Console.WriteLine("Введите координату Х");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y");
int y = Convert.ToInt32(Console.ReadLine());
CheckKoord(x, y);
Console.WriteLine($"это четверть № {CheckKoord2(x, y)}");

void CheckKoord(int x, int y)
{
    if (x > 0 && y > 0)
        Console.WriteLine("Четверть № 1");
    else if (x < 0 && y > 0)
        Console.WriteLine("Четверть № 2");
    else if (x < 0 && y < 0)
       Console.WriteLine("Четверть № 3");
    else if (x > 0 && y < 0)
       Console.WriteLine("Четверть № 4");
    else
        Console.WriteLine("Точка находится на координатной оси");
}


int CheckKoord2(int x, int y)
{
    int res = 0;
    if (x > 0 && y > 0)
        res = 1;
    else if (x < 0 && y > 0)
        res = 2;
    else if (x < 0 && y < 0)
        res = 3;
    else if (x > 0 && y < 0)
        res = 4;
    return res;
}