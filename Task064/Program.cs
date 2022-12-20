// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

using static Common.Helper;

Console.WriteLine();
int userNumber = UserInput("Введите желаемое число: ");
Console.WriteLine();
Console.WriteLine($"Список натуральных чисел от {userNumber} до 1 : ");
Console.WriteLine();
Console.WriteLine(StringRecursion(number: userNumber));



string StringRecursion(int number)
{
    if (number == 1) return number.ToString();

    return number + " " + StringRecursion(number - 1);
}