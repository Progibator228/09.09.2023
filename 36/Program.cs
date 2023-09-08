void Array_Random(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
}
void PrintArray(int[] array)
{
    foreach (int item in array)
        System.Console.Write($"{item} ");
    System.Console.WriteLine();
}
void Sum_of_odd_elements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {

        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    System.Console.WriteLine($"Сумма нечетных элементов равна {sum}");
}

System.Console.WriteLine("Введите размер масива");
int Number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[Number];
Array_Random(array);
PrintArray(array);
Sum_of_odd_elements(array);

