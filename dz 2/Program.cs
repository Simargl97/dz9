int Prompt (string message);
{
    bool message = false;
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите трехзначнное число >");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначнное число, пожалуйста повторите ввод");
    return;
}
Console.WriteLine($"Введенное число '{number}'");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра  '{secondRank}'");
