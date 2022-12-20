// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

using static Common.Helper;

Console.WriteLine();
int userM = UserInput("Введите первое число: ");
Console.WriteLine();
int userN = UserInput("Введите второе число: ");
Console.WriteLine();
int temp = 0;
if (userM > userN)
{
    temp = userM;
    userM = userN;
    userN = temp;
}

Console.WriteLine($"Сумма натуральных чисел от {userM} до {userN} равняется: ");
Console.WriteLine();
int result = SumOfNumbersMtoN(userM, userN);
Console.WriteLine(result);
Console.WriteLine();



int SumOfNumbersMtoN(int startValue, int endValue)
{
    if (startValue == endValue)
    {
        return startValue;
    }
    return SumOfNumbersMtoN(startValue, endValue - 1) + endValue;
}