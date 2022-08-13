// Задача 13: напишите программу которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Введите целое число, не менее трёх знаков");
string A = Console.ReadLine();
string Tretia = numberThRee (A);
Console.WriteLine($"третья цифра во введенном числе равна {Tretia}");
string numberThRee (string Nstring)
{
        if (Nstring.Length < 3) 
    {
        string name = "Во введенном числе третьей цифры нет";
        return name;
    }
    else
    {
        return Convert.ToString(Nstring[2]);
    }
} 