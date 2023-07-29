Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (count<num)
{
    int what = count;
    if ((what % 2) == 0)
{
    Console.WriteLine(what);
}
count++;
}