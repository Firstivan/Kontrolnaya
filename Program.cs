/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами. 
     Примеры:
[“Hello”,   “2”,        “world”,    “:-)”]              →   [“2”, “:-)”]
[“1234”,    “1567”,     “-2”,       “computer science”] →   [“-2”]
[“Russia”,  “Denmark”,  “Kazan”]                        →   []*/


﻿string[] array = new string[] {"Hello", "2", "world", ":-)"};
//string[] array = new string[] {"1234", "1567", "-2", "computer science"};
//string[] array = new string[] {"Russia", "Denmark", "Kazan"};
string[] res = new string[5];
int j = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        res[j] = array[i];
        Console.Write(res[j] + "  ");
        j = j + 1;
    }
}