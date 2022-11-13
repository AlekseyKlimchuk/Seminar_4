// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B");

Console.Write("Введите число A: ");
int numA = int.Parse(Console.ReadLine()!);;
Console.Write("Введите число B: ");
int numB = int.Parse(Console.ReadLine()!);;

int DefExpon(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }
    return result;
}



int exp = DefExpon(numA, numB);
Console.WriteLine("Число А в степени B =" + exp);

