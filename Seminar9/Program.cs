int[,] Create2drandomArray()
{
    Console.Write("Please input number of rows ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please input number of columns ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please input number of MinValue ");
    int MinValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please input number of MaxValue ");
    int MaxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(MinValue, MaxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

/* Задайте значение N. Напишите программу, которая
выведет все натуральные числа в промежутке от 1 до N.
*/

/*Напишите программу, которая будет принимать на вход
 число и возвращать сумму его цифр.
*/

//рекурсивные методы не отднозначны, при самовызове занимается очень много памяти
//рекурсивыне методы быстрее чем итерационные

/*
void SHowNums(int num)
{
    if(num > 1) SHowNums(num - 1);
    Console.Write(num + " ");
}
SHowNums(5);
*/

int SumOFDigits(int num)
{
    if (num != 0) return SumOFDigits(num / 10) + num % 10;
    else return 0;
}
// how it works
// f(1234) -> 4 + f(123)
// f(123)  -> 3 + f(12)
// f(12)   -> 2 + f(1)
// f(1)     -> 1 + f(0)
// f(0)    -> 0
//



//Задайте значения M и N. Напишите программу, которая выведет все
//натуральные числа в промежутке от M до N.

//Напишите программу, которая на вход принимает два числа A и B,
//и возводит число А в целую степень B.

/*void ShowNumbers(int m, int n){
    Console.Write(m + " ");
    if(m < n) ShowNumbers(m+1, n);
    if(m > n) ShowNumbers(m-1, n);
}
Console.WriteLine("Please input number M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input number N");
int numN = Convert.ToInt32(Console.ReadLine());
ShowNumbers(numM, numN);
*/

//Напишите программу, которая на вход принимает два числа A и B,
//и возводит число А в целую степень B.

double FindDegree(double a, double b){
    if(b > 0) return a*FindDegree(a, b - 1);
    if(b < 0) return 1/a*FindDegree(a, b + 1);
    else return 1;
}
Console.WriteLine("Please input number A");
double numA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please input number B");
double numB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(FindDegree(numA, numB));