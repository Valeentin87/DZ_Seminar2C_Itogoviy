/* Задача 10. Напишите программу, которая принимает на вход трёхзначное чсило и на выходе показывает вторую цифру этого числа*/
Console.WriteLine("Введите трёх значное число");
char Vtoroe = SecondNumber(Console.ReadLine());
Console.WriteLine($"Второе число равно = {Vtoroe}");
char SecondNumber(string number)
{
char NumberTwo = Convert.ToChar(number[1]);
return NumberTwo;
}
