int [] array= new int [6];

int number=0;

for (int i = 0; i < array.Length; i++)
{
    array[i]= new Random().Next(100,999);
    System.Console.Write(array[i]+" ");

    if (array[i] %2)

    {
        number=number+1;
    }
}
System.Console.Write(number);