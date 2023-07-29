Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if ((num % 2) == 0)
{
    Console.WriteLine(num);
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine(num);
    Console.WriteLine("нечетное");
}
