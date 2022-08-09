Console.Clear();
string[] array = new string[5];
Console.WriteLine("Заполните массив: ");
for (int i = 0; i < 5; i++)
{
    array[i] = Console.ReadLine();
}
Console.WriteLine();
Console.Write("[" + string.Join(",", array) + "]");
Console.Write(" -> [ ");

for (int i = 0; i < 5; i++)
{


    if (array[i].Length <= 3)
        Console.Write($"{array[i]},");


}

Console.Write("\b]");
