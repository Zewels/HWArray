// Задание 1
// Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.

string GetStringFromCharArray (char [,] chars)
{
    string res = "";
    foreach (char elem in chars)
    {
        res += elem;
    }
    return res;
}

char [,] chars = {{'a','b','c','d'},
                  {'f','g','t','y'}};

string str = GetStringFromCharArray(chars);
Console.WriteLine(str);

// Задание 2
// Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string FilterSring(string str)
{
    string res = str.ToLower();
 
    return res;
}

string str = "If You Read This, That I Did It";
Console.WriteLine(FilterSring(str));

// Задание 3
// Задайте произвольную строку. Выясните, является ли она палиндромом.

string FilterSring(string str)
{
    string res = str.ToLower();
    string count = "";
    foreach(char elem in res)
    {
        if(elem != ' ')
        {
            count+=elem;
        }
    }
    return count;
}

string IsPalindrome(string str)
{
    bool flag = false;
    for(int i = 0; i<str.Length/2; i++)
    {
        if(str[i] == str[str.Length-i-1])
        {
            flag = true;
        }
        else
        {
            return("String is not palindrome");
        }
    }
    if(flag)
    {
        return("String is palindrome");
    }
    return("String is not palindrome");
}

string str = "Sagas";
string res = FilterSring(str);
Console.WriteLine(IsPalindrome(res));