public class MainClass
{
    public static void Main()
    {

        int[] MyArray_1 = { 1, 3, 4, 5, 6 };
        int[] MyArray_2 = { 2, 3, 5, 5, 0 };
        int Count = 0;

         for (int i = 0; i < MyArray_1.Length; i++)
            {
                for (int j = 0; j < MyArray_2.Length; j++)
                {
                    if (MyArray_1 == MyArray_2)
                        Count++;
                }

    
    Console.Write($"Совпадение {Count} элементов");
    }

    }
}



