void Array_Random(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 20);
    }
}
void PrintArray(int[] array)
{
    foreach (int item in array)
        System.Console.Write($"{item} ");
    System.Console.WriteLine();
}
void Even_number_counter(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    System.Console.WriteLine($"Количество четных чисел в масиве = {count}");
}

System.Console.WriteLine("Введите размер масива");
int Number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[Number];
Array_Random(array);
PrintArray(array);
Even_number_counter(array);