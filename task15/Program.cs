// Написать программукоторая принимает на вход цифру, обозначающую день недели и проверяет является ли этот день выходным.
//6->да  7->да  1->нет

Console.Clear();
Console.WriteLine("Введите чило от 1 до 7:");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
        Console.WriteLine("Понедельник - Не выходной");
        break;
    case 2:
        Console.WriteLine("Вторник - Не выходной");
        break;
    case 3:
        Console.WriteLine("Среда - Не выходной");
        break;
    case 4:
        Console.WriteLine("Четверг - Не выходной");
        break;
    case 5:
        Console.WriteLine("Пятница - Не выходной");
        break;
    case 6:
        Console.WriteLine("Суббота - Выходной");
        break;
    case 7:
        Console.WriteLine("Воскресенье - Выходной");
        break;
    default:
    Console.WriteLine("Нет такого дня");
        break;
}