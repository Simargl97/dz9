// Вид 1
void Method1()
{
    Console.WriteLine("Автор ....");
}
Method1();

// Вид2

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

// Вид3

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

//Вид4

string Method4(int count, string c)
{
    
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + c;
    }
    return result;
}
string  res = Method4(10, "12");
Console.WriteLine(res);