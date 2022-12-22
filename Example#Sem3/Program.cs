//void GetDiapazone(int Quadrant)
//{
//    if(Quadrant == 1) Console.WriteLine("x > 0 and y > 0")
//}

/*
//int GerQuadrant(double x, double y)
{
    int result = 0;
    if(x > 0 && y > 0) result = 1;
    else if(x < 0 && y > 0) result = 2;
    else if(x < 0 && y < 0) result = 3;
    else if(x > 0 && y < 0) result = 4;
    return result;
}

Console.Write("Please input x ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Please input y ");
double y = Convert.ToDouble(Console.ReadLine());
if(x != 0 && y !=0) Console.WriteLine($"Quadrant is {GerQuadrant(x, y)}");
else Console.WriteLine("Точка на координатной прямой");
*/

/*void QuadTable(int number)
{
    int current = 1;
    while(current <= number)
    {
        Console.Write(current * current + " ");
        current++;
    } 
}
Console.Write("Input a number please ");
int number = Convert.ToInt32(Console.ReadLine());
QuadTable(number);
*/

double Giptenusa (double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2)+ Math.Pow(y1 - y2, 2));
}
Console.Write("Input a x1 please ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a y1 please ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a x2 please ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a y2 please ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Расстояние между точками равно {Math.Round(Giptenusa(x1, y1, x2, y2),2)}");
