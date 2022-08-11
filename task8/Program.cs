Console.WriteLine("Введите чило: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;
if(count < N) 
{
    while (count <= N)
    {
        Console.WriteLine (count);
        count+=2;
    }
}
else
{
        Console.WriteLine ("Введите целое число больше 2");
}