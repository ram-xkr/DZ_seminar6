// Задача 43: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;
Clear();
Write("Введите 2 значения для первой прямой (Enter): ");
double k1 = int.Parse(ReadLine()!);
double b1 = int.Parse(ReadLine()!);
Write("Введите 2 значения для второй прямой (Enter): ");
double k2 = int.Parse(ReadLine()!);
double b2 = int.Parse(ReadLine()!);
Peresechenie(k1, b1, k2, b2);

// if (k1 == k2)
// {
//     Write("Прямые не пересекаются.");
//     return;
// }
// Write($"({k1}, {b1}, {k2}, {b2}");
// double x = (b1 - b2) / (k2 - k1);
// double y = k1 * x + b1;
// WriteLine($"({x}, {y})");



void Peresechenie(double k11, double b11, double k22, double b22)
{
    if (k11 == k22)
    {
        Write("Прямые не пересекаются.");
        return;
    }
    double x = (b11 - b22) / (k22 - k11);
    double y = k11 * x + b11;
    WriteLine($"({x}, {y})");
}