// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] generateArray(int arraySize)
{
    double[] array = new double[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        Console.WriteLine($"Введите {i} индекс массива: ");
        int value = Convert.ToInt32(Console.ReadLine());
        array[i] = value;
    }
    return array;
}

double[] getMaxAndMinNumber(double[] array)
{
    double[] minMaxArray = new double[2];
    double maxNumber = array[0];
    double minNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (maxNumber < array[i])
        {
            maxNumber = array[i];
        }
        if (minNumber > array[i])
        {
            minNumber = array[i];
        }
    }
    minMaxArray[0] = minNumber;
    minMaxArray[1] = maxNumber;
    return minMaxArray;
}
try
{
    Console.WriteLine("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] newArray = generateArray(size);
    double[] minAndMaxArrayValues = getMaxAndMinNumber(newArray);

    Console.Write($"Разница между максимальным и минимальным значениями массива: {minAndMaxArrayValues[1] - minAndMaxArrayValues[0]} ");
}
catch (Exception ex)
{
    Console.WriteLine($"Введенное значение имеет неверный формат. Ошибка: {ex.Message}");
}