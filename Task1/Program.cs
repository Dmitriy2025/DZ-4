// // Задача 1
// // Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// // Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.


Console.Clear();

while (true)
{
    Console.Write("Введите целое число (для выхода введите q): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "q")
    {
        Console.WriteLine("Выход из программы.");
        break; 
    }

    if (int.TryParse(input, out int number))
    {
        string numberString = number.ToString();
        Console.WriteLine($"Число: {number}");

        int length = numberString.Length;
        int[] array = new int[length];
        int sum = 0;

        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(numberString[i].ToString());
            sum += array[i];
        }

        if (sum % 2 == 0)
        {
            Console.WriteLine($"Сумма цифр чётная ({sum}). Программа завершена.");
            break;
        }
    }
    else
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q' для завершения.");
    }
}

