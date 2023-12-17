// Задача 3 
// Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.)

Console.Clear();

void InputArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(1, 100);
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void ReverseArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length / 2; i++)
    {
        int temporary = array[i];
        array[i] = array[length - i - 1];
        array[length - i - 1] = temporary;
    }
}

int[] array = new int[10];
InputArray(array);

Console.WriteLine("Исходный массив:");
PrintArray(array);

ReverseArray(array);

Console.WriteLine("Развернутый массив:");
PrintArray(array);

