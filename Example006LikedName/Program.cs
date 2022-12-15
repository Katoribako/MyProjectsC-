Console.Write("Please enter your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "bob")
{
    Console.WriteLine("Welcome home Bob!");
}
else
{
    Console.Write("Hello ");
    Console.WriteLine(username);
}
