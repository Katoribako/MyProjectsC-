string method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + c;
        i ++;
    }
    return result;
}
string res = method4(c: "jarooom", count: 8);
Console.WriteLine(res);