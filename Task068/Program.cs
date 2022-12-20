// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

using static Common.Helper;

Console.WriteLine();
int userM = UserInput("Введите первое число: ");
Console.WriteLine();
int userN = UserInput("Введите второе число: ");
Console.WriteLine();

if (userM < 0 || userN < 0)
{
    Console.WriteLine("Введенные числа должны быть положительными!");
    return;
}

int result = AckermannFunction(userM, userN);
Console.Write("Значение функция Аккермана от заданных числам равняется:   ");
Console.WriteLine(result);

int AckermannFunction(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    else if (numberM > 0 && numberN == 0)
    {
        return AckermannFunction(numberM - 1, 1);
    }
    else if (numberM > 0 && numberN > 0)
    {
        return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
    }
    return AckermannFunction(numberM, numberN);
}