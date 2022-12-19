int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int[] array = {10, 32, 15, 35, 24, 243, 245, 21, 17, };

int max1 = Max(array[0], array[1], array[2]);
Console.WriteLine("First max is " + max1);
int max2 = Max(array[3], array[4], array[5]);
Console.WriteLine("Second max is " + max2);
int max3 = Max(array[6], array[7], array[8]);
Console.WriteLine("Third max is " + max3);

int max = Max(max1, max2, max3);
Console.WriteLine("Total max is " + max);
