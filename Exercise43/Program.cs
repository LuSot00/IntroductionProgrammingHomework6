
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2
// и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double CrossPointX(double parametr1, double coef1, double parametr2, double coef2)
{
    double crossX = (parametr2-parametr1)/(coef1-coef2);
    return crossX;
}

double CrossPointY(double parametr1, double coef1, double parametr2, double coef2)
{
    double crossX = (parametr2-parametr1)/(coef1-coef2);
    double crossY = coef1*crossX+parametr1;
    return crossY;
}

Console.WriteLine();
Console.WriteLine($"Точка пересечения двух прямых --> ({Math.Round(CrossPointX(b1,k1,b2,k2), 2)}, {Math.Round(CrossPointY(b1,k1,b2,k2), 2)})");