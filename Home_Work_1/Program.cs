/*
Задайте массив заполненный 
случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
//Контроль ввода
int InputControl(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number > 0)
            {
            return number;
            }
            else
            {
                Console.WriteLine("Вы ввели значение меньше допустимого. Пожалуйста введите корректное значение.");
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Пожалуйста введите корректное значение.");
        }
    }
}
//рандомное заполнение массива
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(100, 1000);
        index++;
    }
}
//Печать массива в консоль
void PrintArray(int[] array)
{
    int lenght = array.Length;
    lenght = lenght - 1;
    int position = 0;
    while (position < lenght)
    {
        Console.Write($"{array[position]}, ");
        position++;
    }
    Console.WriteLine($"{array[position]}");
}
//Нахождените четных значений
void SearchEven(int[]array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            even+=1;
        }
    }
    Console.WriteLine($"Количество четных чисел в массиве - {even}");
} 

//Основной код
int length = InputControl("Введите размер массива");
int[] array = new int [length];
Console.WriteLine("Значения внутри заданного массива:");
FillArray(array);
PrintArray(array);
SearchEven(array);


