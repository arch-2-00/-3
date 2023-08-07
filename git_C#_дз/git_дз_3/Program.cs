Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count<=num)
{
    int what = count;
    if ((what % 1) == 0)
{
    Console.WriteLine(Math.Pow(what,3));
}
count++;
}