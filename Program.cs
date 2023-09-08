/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами. 
     Примеры:
[“Hello”,   “2”,        “world”,    “:-)”]              →   [“2”, “:-)”]
[“1234”,    “1567”,     “-2”,       “computer science”] →   [“-2”]
[“Russia”,  “Denmark”,  “Kazan”]                        →   []*/


﻿string[] myArray = new string[7] { "I", "-233", "7777", "<3", "my", "46-7", "BF!" };
string[] myArray2 = new string[myArray.Length];
void newArray(string[] myArray, string[] myArray2)
{
    int count = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i].Length <= 3)
        {
            myArray2[count] = myArray[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.WriteLine();
}
newArray(myArray, myArray2);
PrintArray(myArray2);