/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */
Console.WriteLine("Введите коррдинаты точки А");
Console.WriteLine("Введите координату A1 первой точки: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату A2 первой точки: ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату A3 первой точки: ");
int a3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коррдинаты точки B");
Console.WriteLine("Введите координату B1 первой точки: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату B2 первой точки: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату B3 первой точки: ");
int b3 = Convert.ToInt32(Console.ReadLine());
Spice(a1, a2, a3, b1, b2, b3);

void Spice(int a1, int a2, int a3, int b1, int b2, int b3)
{
    int A = a1 - b1;
    int B = a2 - b2;
    int C = a3 - b3;

    double length = Math.Sqrt(A * A + B * B + C * C);
    double length2 = Math.Round(length, 2);
    Console.WriteLine($"Длинна отрезка {length2}");
}
