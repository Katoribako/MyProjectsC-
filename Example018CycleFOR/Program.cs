string method4(string msg, int count)
{
    string result = String.Empty;
    for (int i = 0; i < count; i ++)
    {
        result = result + msg;
    }
    return result;
}
string res = method4(msg: "test", count: 5);
Console.WriteLine(res);