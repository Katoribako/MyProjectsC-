int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int numbera1 = new Random().Next(1, 1000);
Console.WriteLine("First number of a first maximum is " + numbera1);
int numberb1 = new Random().Next(1, 1000);
Console.WriteLine("Second number of a first maximum is " + numberb1);
int numberc1 = new Random().Next(1, 1000);
Console.WriteLine("Third number of a first maximum is " + numberc1);
int numbera2= new Random().Next(1, 1000);
Console.WriteLine("First number of a second maximum is " + numbera2);
int numberb2 = new Random().Next(1, 1000);
Console.WriteLine("Second number of a second maximum is " + numberb2);
int numberc2 = new Random().Next(1, 1000);
Console.WriteLine("Third number of a second maximum is " + numberc2);
int numbera3 = new Random().Next(1, 1000);
Console.WriteLine("First number of a third maximum is " + numbera3);
int numberb3 = new Random().Next(1, 1000);
Console.WriteLine("Second number of a third maximum is " + numberb3);
int numberc3 = new Random().Next(1, 1000);
Console.WriteLine("Third number of a third maximum is " + numberc3);

int max1 = Max(numbera1, numberb1, numberc1);
Console.WriteLine("First max is " + max1);
int max2 = Max(numbera2, numberb2, numberc2);
Console.WriteLine("Second max is " + max2);
int max3 = Max(numbera3, numberb3, numberc3);
Console.WriteLine("Third max is " + max3);

int max = Max(max1, max2, max3);
Console.WriteLine("Total max is " + max);
