﻿/* Условие задачи: напишите программу, которая на вход принимает два числа
и проверяет,является ли первое число квадратом второго */

Console.WriteLine("number_A");
string number_As = Console.ReadLine() ?? "";
int number_Ai;
Console.WriteLine("number_B");
string number_Bs = Console.ReadLine() ?? "";
int number_Bi;
if (int.TryParse(number_As, out number_Ai))
{
    if (int.TryParse(number_Bs, out number_Bi))
    {
        if (number_Ai == number_Bi * number_Bi)
        {
            Console.WriteLine("Yahoo");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
    else
    {
        Console.WriteLine("Error");
    }
}
else
{
    Console.WriteLine("Error");
}