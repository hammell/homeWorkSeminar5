// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
//метод создания массива
int[] GetArray(int size, int startValue, int endValue)
{
    var array = new int[size];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(startValue, endValue + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) // Если по ТЗ- i = 1, если с точки зрения пользователя, то i = 0!!!
    {
        Console.Write($"{array[i]} ");
    }
    return;
}
int SumOddPosition (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i=i+2)
    {
        sum = sum + array[i]; 
    }
    return sum;
}
try
{
    Console.WriteLine("Введите размер массива:");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите первое значение массива: ");
    int start = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите последнее значение массива: ");
    int end = Convert.ToInt32(Console.ReadLine());

    int[] array = GetArray(size, start, end);
    Console.WriteLine($"Массив:");
    PrintArray(array);
    Console.WriteLine("");
    int sum = SumOddPosition(array);
    Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях: {sum}");
}
catch (Exception ex)
{
    Console.WriteLine($"Введеное значение имеет неверный формат. Ошибка: {ex.Message}");
}