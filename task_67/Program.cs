// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int number = 4533;
int SummaTsifr(int Chislo)
{
    if(Chislo <=0) return 0;
    return SummaTsifr(Chislo / 10) + (Chislo % 10);
}

Console.Write(SummaTsifr(number));