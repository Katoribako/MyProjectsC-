/*int[,] Create2drandomArray()
{
    Console.Write("Please input number of rows ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please input number of columns ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please input number of MinValue ");
    int MinValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please input number of MaxValue ");
    int MaxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int [rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(MinValue, MaxValue + 1);
        }
    }
    return array;
}*/
void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
/*
int[,] NewArray = Create2drandomArray();
Show2dArray(NewArray);*/


//Задайте двумерный массив размера m на n, каждый 
//элемент в массиве находится по формуле: Aij = i+j. 
//Выведите полученный массив на экран.

/*Задайте двумерный массив. Найдите элементы,
у которых оба индекса чётные,
 и замените эти элементы на их квадраты.*/

 /*Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали
 (с индексами (0,0); (1;1) и т.д.
*/


//Задайте двумерный массив размера m на n, каждый 
//элемент в массиве находится по формуле: Aij = i+j. 
//Выведите полученный массив на экран.

/*int[,] Create2drandomArray(int rows, int columns)
{
    int[,] array = new int [rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}
Console.Write("Please input number of rows ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input number of columns ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] NewArray = Create2drandomArray(rows, columns);
Show2dArray(NewArray);*/

/*Задайте двумерный массив. Найдите элементы,
у которых оба индекса чётные,
 и замените эти элементы на их квадраты.*/

/* int[,] Create2drandomArray()
{
    Console.Write("Please input number of rows ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please input number of columns ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please input number of MinValue ");
    int MinValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please input number of MaxValue ");
    int MaxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int [rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(MinValue, MaxValue + 1);
        }
    }
    return array;
}

void EvenIndexFilter(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i += 2)
    {
        for(int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
    }
}
int[,] Newarray = Create2drandomArray();
Show2dArray(Newarray);
EvenIndexFilter(Newarray);
Show2dArray(Newarray);*/

/*Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали
 (с индексами (0,0); (1;1) и т.д.*/


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

    int[,] array = new int [rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(MinValue, MaxValue + 1);
        }
    }
    return array;
}
int SumMainDiagonal(int[,] array)
{
    int summ = 0;
    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    {
        summ += array[i,i];
    }
    return summ;
}


int[,] Newarray = Create2drandomArray();
Show2dArray(Newarray);
Console.WriteLine($"Summ is {SumMainDiagonal(Newarray)}");

