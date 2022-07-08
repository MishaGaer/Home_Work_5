/*
Задайте одномерный массив, 
заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
        array[index] = new Random().Next(-999, 1000);
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
//нахождение суммы
void UnevenSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i+2)
    {
        sum += array[i];
    }
    Console.WriteLine($"Сумма элементов массива на нечетных позициях  - {sum}");
}

//Основной код
int length = InputControl("Введите размер массива");
int[] array = new int [length];
Console.WriteLine("Значения внутри заданного массива:");
FillArray(array);
PrintArray(array);
if (length > 1)
{
UnevenSum(array);
}
else
{
    Console.WriteLine("В массиве всего один элемент");
}