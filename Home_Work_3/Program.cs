/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и 
минимальным элементов массива.

[3 7 22 2 78] -> 76
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
void FillArray(double[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(-99, 100);
        index++;
    }
}
//Печать массива в консоль
void PrintArray(double[] array)
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
//нахождение минимума и максимума
(double, double) GetMaxAndMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else
        {
            if (array[i] < min)
            {
                min = array[i];
            }
        }
    }
    return (max, min);
}
//Основной код
int length = InputControl("Введите размер массива");
double[] array = new double[length];
Console.WriteLine("Значения внутри заданного массива:");
FillArray(array);
PrintArray(array);
(double max, double min) = GetMaxAndMin(array);
Console.WriteLine($"Разница между максимальным ({max}) и минимальным({min}) значениями массива равна {max - min}");

