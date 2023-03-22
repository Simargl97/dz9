/* string Method4(int count, string c)
{
    
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
string  res = Method4(10, "12");
Console.WriteLine(res); */

/* Таблица Умножения!!!

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
} */

string text =  "- Я думаю"
            + "Не думаю"
            + "Nooooooo"
            + "Yessssss"


string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{str[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);