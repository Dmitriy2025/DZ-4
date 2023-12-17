// Задача 2
// Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000); 

}

bool CheckCondition(int x)
{
    if (x%2 == 0) 
            return true;
        return false;
}


void ReleaseArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (CheckCondition(array[i]) == true)
            count ++;
    Console.WriteLine($"Количество чётных чисел в массиве: {count}");
}

int[] array = new int[10]; 
InputArray(array);

Console.WriteLine(string.Join(", ", array));
ReleaseArray(array);
