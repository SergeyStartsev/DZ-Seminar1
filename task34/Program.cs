// Массив заполненный случайными положительными трёхзначными числами.Программа, которая покажет количество чётных чисел в массиве.

Console.Clear();
Console.WriteLine("Введите количество чисел");
int q = Convert.ToInt32(Console.ReadLine());
int[] array = new int[q];
int count = 0;
for (int i = 0; i < q; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"Количество четных чисел в массиве = {count}");
Console.WriteLine();

