// перевести десятичное число в двоичное представление

int numder = 25;

void PrintBinaryView(int decNumber)
{
    if (decNumber <=0) return;
    PrintBinaryView(decNumber / 2);
    Console.Write(decNumber % 2);
}

PrintBinaryView(numder);