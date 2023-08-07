// ∆t² = ∆y² + ∆z² 
// Еще раз по теореме Пифагора ∆r² = ∆x² + ∆t²
Console.Write("Введите координату х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату у: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату у: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double num= Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
System.Console.WriteLine(num);