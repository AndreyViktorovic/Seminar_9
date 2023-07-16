// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int numder = 6;

void PrintBinaryView(int LastNumber)
{
    if (LastNumber <=0) return;
    PrintBinaryView(LastNumber - 1);
    Console.Write(LastNumber + " ");
}

PrintBinaryView(numder);