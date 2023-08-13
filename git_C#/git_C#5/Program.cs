int [] array= new int [12];

int sumNegNumber=0;
int sumPosNumber=0;


for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(-9,10);
    System.Console.Write(array[i]+" ");

    if (array[i]>0)
    {
        sumPosNumber=sumPosNumber+array[i];
    }
    else
    {
        sumNegNumber=sumNegNumber+array[i];
    }
}
System.Console.WriteLine($"Сумма положительных = {sumPosNumber}, отрицательных = {sumNegNumber}");
