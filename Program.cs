﻿//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент: ");
    string symbol = Console.ReadLine()!;
    arrayStrings[i] = symbol;
}

string[] arrayFinal = new string[size];
int length = 3;
int count = 0;

for (int i = 0; i < size; i++)
{
    if (arrayStrings[i].Length <= length)
    {
        arrayFinal[count] = arrayStrings[i];
        count++;
    }
}

Console.WriteLine ($"[{string.Join(";", arrayStrings)}] -> [{string.Join(";", arrayFinal)}]");
