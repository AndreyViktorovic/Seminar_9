﻿// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int numberM = 6;
int numberN = 10;

void PrintBinaryView(int LastNumber, int FirsNumber)
{
    if (LastNumber <= FirsNumber - 1) return;
    PrintBinaryView(LastNumber - 1, FirsNumber);
    Console.Write(LastNumber + " ");
}

PrintBinaryView(numberN, numberM);