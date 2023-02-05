// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//
//  0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите количество элементов массива: ");
int elementsCount = Convert.ToInt32(Console.ReadLine());

int NumbersGreaterThanZero(int[] numbersArray)
{
    int count = 0;
    for (int i = 0; i < numbersArray.Length; i++)
    {
        if (numbersArray[i] > 0)
            count++;
    }
    return count;
}

int[] numbersArray = new int[elementsCount];
int temp;
for (int i = 0; i < elementsCount; i++)
{
    Console.Write($"Введите {i + 1}-е число: ");
    if (int.TryParse(Console.ReadLine(), out temp))
        numbersArray[i] = temp;
    else
    {
        Console.WriteLine("Введено некорректное значение");
        Environment.Exit(0);
    }
}

void PrintArray(int[] numbersArray)
{
    Console.Write("[");
    for (int i = 0; i < numbersArray.Length; i++)
    {
        if (i < numbersArray.Length - 1)
            Console.Write($"{numbersArray[i]}, ");
        else Console.Write($"{numbersArray[i]}");
    }
    Console.Write("]");
}

PrintArray(numbersArray);
int count = NumbersGreaterThanZero(numbersArray);
Console.WriteLine($" Количество чисел больше 0 -> {count}");