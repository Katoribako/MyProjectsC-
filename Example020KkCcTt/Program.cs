//— Я думаю, — сказал князь, улыбаясь, — что,
//ежели бы вас послали вместо нашего милого
//Винценгероде, вы бы взяли приступом согласие
//прусского короля. Вы так красноречивы. Вы
//дадите мне чаю?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого"
            + "Винценгероде, вы бы взяли приступом согласие"
            + "прусского короля. Вы так красноречивы. Вы"
            + "дадите мне чаю?";

//string s = "qwerty"
//            012345
//s[3] = r

string replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
string newText1 = replace(newText, 'к', 'К');
Console.WriteLine(newText1);
Console.WriteLine();
string newText2 = replace(newText1, 'с', 'С');
Console.WriteLine(newText2);
Console.WriteLine();