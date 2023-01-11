void method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i ++;
    }
}
method2(msg:"text", count: 5);
method2(count: 5, msg:"there you are"); //это одно и то же