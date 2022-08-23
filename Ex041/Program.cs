// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел которое вы хотите ввести: ");
int countM = int.Parse(Console.ReadLine());

int CountPositiveDigits(int count)
{    
    int result = 0;
    for (int i = 1; i < count+1; i++)
    {
        Console.Write($"Введите {i} число: ");
        int number = int.Parse(Console.ReadLine());
        if (number > 0) result++;
    }
    return result;
}

int result = CountPositiveDigits(countM);
Console.Write($"Количество введённых положительных чисел равно {result}");
