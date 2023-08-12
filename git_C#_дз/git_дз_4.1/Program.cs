Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num/100;
int num2 = num/10;
int num3= num2 %10;
int num4= num %10;
Console.WriteLine(num1+num3+num4);