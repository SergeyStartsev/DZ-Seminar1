// Написать программу, которая задаёт массив из 8 элементов и выводит их на экран
// Пример 1,2,5,7,19,15,9,8->[1,2,5,7,19]  6,1,33,9,28,14,15,97->[6,1,33]

Console.Clear();
int [] array = new int [8];
for (int count = 0; count < 8;)
{
    Console.WriteLine ($"Введите {count + 1} элемент массива");
    array[count] = Convert.ToInt32(Console.ReadLine());
    count ++;
}
int i = 0; 
Console.Write("[");
while (i < 8)
{
    Console.Write(array [i]);
    Console.Write(" ");
    i++;
}
Console.Write("]");