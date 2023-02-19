string[] array2;
Console.WriteLine("Введите массив строк через пробел: ");
string array1 = Console.ReadLine()!;
array2 = array1.Split(' ');
var result = new string[array2.Length];
var realSize = 0;
foreach (var value in array2)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
Console.WriteLine(string.Join(' ', result, 0, realSize));
Console.ReadKey(true);





