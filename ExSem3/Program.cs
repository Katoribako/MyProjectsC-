//Напишите программу, которая принимает на вход 
//число (А) и выдаёт сумму чисел от 1 до А.

/*int getNum (int num)
{
   int sum = 0;
   for (int current = 0; current <= num; current++)
       sum += current;
    return sum;
}
Console.WriteLine("input a number ");
int a = Convert.ToInt32(Console.ReadLine());

int result = getNum(a);
Console.WriteLine(result);
*/

/*int getNum (int num)
{
    int fact = 1;
    for (int currentnum = 1; currentnum <= num; currentnum++)
    {
        fact *= currentnum;
    }
    return fact;
}
Console.WriteLine("input a number ");
int a = Convert.ToInt32(Console.ReadLine());

int result = getNum(a);
Console.WriteLine(result);
*/

/*int getNum(int num)
{
    int count = 1;
    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    count = count - 1;
    return count;
}
Console.WriteLine("input a number ");
int a = Convert.ToInt32(Console.ReadLine());

int result = getNum(a);
Console.WriteLine(result);
*/

int[] createRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int index = 0; index < size; index++)
    {
        array[index] = new Random().Next(minValue, maxValue + 1); //на практике next не видит последнего MaxValue
    }
    return array;
}
void RightArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("please input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("please input a minimum value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("please input a maximum value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[]newArray = createRandomArray(length, minValue, maxValue);
RightArray(newArray);
