// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Программа, которая принимает на вход число и выдаёт сумму цифр в числе");
Console.Write("Введите число: ");
int numA = int.Parse(Console.ReadLine()!);;

int SumNumA(int numA)
{

    int count = Convert.ToString(numA).Length;
    int numB = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
        numB = numA - numA % 10;
        result = result + (numA - numB);
        numA = numA / 10;
    }
    return result;
}

int sumNumA = SumNumA(numA);
Console.WriteLine("Сумма цифр : " + sumNumA);