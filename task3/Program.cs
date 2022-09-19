// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
//метод создания массива
int[] generateArray(int arraySize)
{
    int[] array = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        Console.WriteLine($"Введите {i} индекс массива: ");
        int value = Convert.ToInt32(Console.ReadLine());
        array[i] = value;
    }
    return array;
}
void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    return;
}

int[] multiply(int[] array)
{
    if (array.Length % 2 == 0)
    {
        int[] returnArray = new int[array.Length / 2];
        for (int i = 0; i < array.Length / 2; i++)
        {
            returnArray[i] = array[i] * array[array.Length - 1 - i];
        }
        return returnArray;
    }
    else
    {
        int[] returnArray = new int[array.Length / 2 + 1];
        for (int i = 0; i <= array.Length / 2; i++)
        {
            if (i == array.Length - 1 - i)
            {
                returnArray[i] = array[i];
            }
            else
            {
                returnArray[i] = array[i] * array[array.Length - 1 - i];
            }
        }
        return returnArray;
    }
}
try
{
    Console.WriteLine("Введите размер массива:");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] generatedArray = generateArray(size);
    printArray(multiply(generatedArray));
}
catch (Exception ex)
{
    Console.WriteLine($"Введенное значение имеет неверный формат. Ошибка: {ex.Message}");
}