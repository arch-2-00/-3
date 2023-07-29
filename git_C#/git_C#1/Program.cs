Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2)
{
    Console.Write("max= ");
    Console.WriteLine(num1);
    Console.Write("min= ");
    Console.Write(num2);
}
else
{
    Console.Write("max= ");
    Console.WriteLine(num2);
    Console.Write("min= ");
    Console.Write(num1);
}
