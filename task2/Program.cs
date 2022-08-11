Console.WriteLine("Введите первое чило:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB)
{
    Console.Write ("max = ");
    Console.WriteLine (numberA);
}
else
{
    Console.Write ("max = ");
    Console.WriteLine (numberB);
}