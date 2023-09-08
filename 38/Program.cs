void Min_Max(double[] array)
{
    double result = 0;
    double max = 0;
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    System.Console.WriteLine($"Максимальное значение   = {max}");
    System.Console.WriteLine($"Минимальное значение  = {min}");
    result = max - min;
    System.Console.WriteLine($"Разница между {max} и {min} = {result}");
}
double[] array = { 3.22, 4.2, 1.15, 77.15, 65.2, };
Min_Max(array);