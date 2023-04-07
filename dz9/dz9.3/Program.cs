// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int m = PrintArray("Введите m: ");
int n = PrintArray("Введите n: ");

int MethodAccermana = Accerman(m, n);

Console.Write($"Функция Аккермана = {MethodAccermana} ");

int Accerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Accerman(m - 1, 1);
  else return Accerman(m - 1, Accerman(m, n - 1));
}

int PrintArray(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
