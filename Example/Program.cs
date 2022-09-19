﻿// Написать программу, которая из имеющегося массива строк формирует новый массив 
//из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
//выполнения алгоритма. При решении не рекомендуется 
//пользоваться коллекциями, лучше обойтись исключительно массивами.

void FillArray(string[] array)
{
    Console.WriteLine("Введите массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        string text = Console.ReadLine() ?? "0";
        array[i] = text;
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        Console.Write($"{array[i]} ");
}

void ChangeArray(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            count++;
        }
     }
    
}

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");
string[] array = new string[size];
string[] copyarray = new string[size];
FillArray(array);
Console.WriteLine("Заданный массив:");
PrintArray(array);
Console.WriteLine("");
ChangeArray(array, copyarray);
Console.WriteLine("Новый массив с перенесенными значениями: ");
PrintArray(copyarray);