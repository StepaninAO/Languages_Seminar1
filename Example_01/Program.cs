﻿// Условие: запишите программу, которая на вход принимает число и выдает его квадрат.

// 1. Выводим приглашение пользователю на ввод числа
Console.Write("Введите число: ");

/* 2. Считываем введенные пользователем символы и
      сохраняем их в строковую переменную userInputString */
string userInputString = Console.ReadLine() ?? "";
/* 
 * !!! Переменная userInputString сейчас строковая (string).
 * Она не может участвовать в математических опрациях!
 * Для этого ее необходимо преобразовать в требуемый численный тип (int, double и прочее)
*/

// 3. Создаем локальную переменную типа double для хранения числа
double userInputDouble;

/* 4. Выполняем преобразование строковой переменной userInputString в числовую userInputDouble,
      в случае успеха, выводим в консоль число, умноженное на само себя */
if (double.TryParse(userInputString, out userInputDouble))
{
    Console.WriteLine(userInputDouble * userInputDouble);
}
else // Иначе (т.е. если не удалось преобразовать строку в число) - ссобщение об ошибке
{
Console.WriteLine("Ошибка ввода! Введите число!");
}