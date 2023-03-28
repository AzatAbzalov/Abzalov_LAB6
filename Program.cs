//Задание 1
//Часть a

//using System.Globalization;
//using System.Text.RegularExpressions;

//Console.WriteLine("Введите строку: ");
//string S = Console.ReadLine();
//Regex R = new Regex(@"abcd(2023)1{7}0\1");
//if (R.IsMatch(S))
//    Console.WriteLine("Введённая строка содержит abcd2023111111102023");
//else
//    Console.WriteLine("Введённая строка не содержит abcd2023111111102023");
//Regex NR = new Regex(@"2023");
//string ext = "happy new year";
//string CS = NR.Replace(S, ext);
//Console.WriteLine("Строка с изменениями: " + CS);

////Часть b

//Regex rnum = new(@"\d+");
//MatchCollection matches = rnum.Matches(S);
//List<long> numbers = new();
//foreach (Match m in matches)
//    numbers.Add(Convert.ToInt64(m.Value));
//Console.WriteLine("Полученные числа: ");
//long sum = 0;
//int max_ind = 0;
//for (int i = 0; i < numbers.Count; i++)
//{
//    Console.Write(numbers[i] + " ");
//    sum += numbers[i];
//    if (numbers[i] > numbers[max_ind]) max_ind = i;
//}
//Console.WriteLine("Cумма = " + sum);
//Console.WriteLine("Максимальное число = " + numbers[max_ind] );
//Console.WriteLine("Индекс максимального числа: " + max_ind);

////Часть c
//string pattern = @"[-+]?\d+([.,]\d+)?";
//string replacement = "number";
//MatchCollection _ = Regex.Matches(S, pattern);
//Console.Write("Массив чисел: ");
//foreach (Match m in matches)
//    Console.Write(m.Value + " ");
//Console.Write("\nИзмененная строка: ");
//string result = Regex.Replace(S, pattern, replacement);
//Console.WriteLine(result);

////Часть d
//string path = @"C:\Users\User1\documents\game.exe";
//pattern = @"(?<=\\|\/)[^\\/:*?""<>|.]+(?=\\|\/|$)";
//matches = Regex.Matches(path, pattern);
//Console.WriteLine("Имена всех каталогов:");
//foreach (Match m in matches)
//    Console.WriteLine(m.Value);

//Задание 2
//Часть а
using System.Text.RegularExpressions;

string[] strs = new string[5];
for (int i = 0;i <5;i++)
{
    Console.Write("Введите строку:");
    strs [i] = Console.ReadLine();

}

Regex R = new Regex("cat");

foreach (string s in strs)
{
    if (R.Matches(s).Count == 2)
        Console.WriteLine(s);
}

//Часть b
//Console.WriteLine();
//string[] strings = {"abcdefeefegrgrs","dfsfkwkekr", "строка с  antidisestablishmentarianism, supercalifragilisticexpialidocious",
//   "Короткая строка", " pneumonoultramicroscopicsilicovolcanoconiosis"};
string[] strings = new string[5];
for (int i = 0; i < strings.Length; i++)
{
    Console.Write($"Введите строку {i + 1}: ");
    strings[i] = Console.ReadLine();
}

string pattern = @"\b\w{10,}\b";
foreach (string str in strings)
{
    Console.WriteLine(str);
    string newStr = Regex.Replace(str, pattern, "*");
    Console.WriteLine("1: " + newStr);
    newStr = Regex.Replace(str, pattern, m => m.Value[0].ToString());
    Console.WriteLine("2: " + newStr);
    newStr = Regex.Replace(str, pattern, m => new string(m.Value[0], m.Value.Length));
    Console.WriteLine("3: " + newStr);
    Console.WriteLine();
}
//Часть c
string[] strings1 = new string[5];
Console.WriteLine("Введите 5 строк:");
for (int i = 0; i < 5; i++)
{
    strings1[i] = Console.ReadLine();
    strings1[i] = Regex.Replace(strings1[i], @"ик(\b|$)", "");
}
Console.WriteLine("Результат:");
foreach (string s in strings1)
{
    Console.WriteLine(s);
}
//Часть d
Console.WriteLine("Введите идентификатор цвета в HTML:");
string input = Console.ReadLine();
bool isHtmlColor = Regex.IsMatch(input, "^#([0-9A-Fa-f]{6})$");
if (isHtmlColor)
{
    Console.WriteLine("Cтрока является 16-м идентификатором цвета в HTML");
}
else
{
    Console.WriteLine("Cтрока не является 16-м идентификатором цвета в HTML");
}
//Часть d
Console.WriteLine("Введите строку:");
string inp = Console.ReadLine();
bool isGuid = Regex.IsMatch(input, "^[0-9A-Fa-f]{8}-[0-9A-Fa-f]{4}-[0-9A-Fa-f]{4}-[0-9A-Fa-f]{4}-[0-9A-Fa-f]{12}$");
if (isGuid)
{
    Console.WriteLine("Cтрока является GUID.");
}
else
{
    Console.WriteLine("Cтрока не является GUID.");
}