﻿// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
var arrayNumber = Console.ReadLine();
int size = arrayNumber.Length;
if (size == 5)
{
    int number;//если строчка состоит из чисел , сюда попадает наше число
    bool isNumber = int.TryParse(arrayNumber, out number); //логический тип данных. True - строка состоит из чисел , False - в строке присутствуют буквы\спец.символы
    if (arrayNumber[0] == arrayNumber[4] && arrayNumber[1] == arrayNumber[3])
    {
        System.Console.WriteLine("Число является палиндромом");   
    }
}
else
Console.WriteLine("Число не является палиндромом");   

