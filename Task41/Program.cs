// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
using static System.Console;
Clear();
Write("Введите несколько чисел через пробел: ");
string[] numbers = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
WriteLine($"Введено {numbers.Length} чисел");
numMoreThanNull(numbers);

void numMoreThanNull(string[] num)
{
    int result = 0;
    int[] M = Array.ConvertAll(num, int.Parse);
    for (int i = 0; i < num.Length; i++)
    {
        if (M[i] > 0)
        {
            result++;
        }
    }
    WriteLine(String.Join(",", M));
    WriteLine($"Чисел больше 0 - {result}");

}