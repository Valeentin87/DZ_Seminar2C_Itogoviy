// Напишите программу, которая на вход принимает цифру, обозначающую день недели и проверяет не является ли этот день выходным
Console.WriteLine("Введите цифру, обозначающую порядковый день в неделе");
int days = Convert.ToInt32(Console.ReadLine());
Console.Write(Vihodnoy(days));
string Vihodnoy (int day)
{
    if (day == 6 || day == 7)
    {
        string otvet = "день является выходным";
        return otvet;
    }
    else
    {
        string otvet = "день является рабочим";
        return otvet;
    }
    
}