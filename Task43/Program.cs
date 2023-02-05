// // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// // значения b1, k1, b2 и k2 задаются пользователем.
// //
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите коэффициент k1: ");
double k1 = UserInput();
Console.Write("Введите коэффициент b1: ");
double b1 = UserInput();
Console.Write("Введите коэффициент k2: ");
double k2 = UserInput();
Console.Write("Введите коэффициент b2: ");
double b2 = UserInput();

double UserInput()
{
    double coefficient;
    if (double.TryParse(Console.ReadLine(), out coefficient));
    else
    {
        Console.WriteLine("Введено некорректное значение.");
        Environment.Exit(0);
    }
    return coefficient;
}

    double x = (b1 - b2) / (k1 - k2) * -1;
    double y = k1 * x + b1;
 
    x = Math.Round(x, 1, MidpointRounding.ToZero);
    y = Math.Round(y, 1, MidpointRounding.ToZero);

if (k1 != k2)
{
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
}
else Console.WriteLine("Коэффициенты координат k1 и k2 совпадают, прямые не пересекаются! ");

