/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите первое значение");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение");
int n = Convert.ToInt32(Console.ReadLine());

SummMtoN(m, n);

void SummMtoN(int m, int N)
{
    Console.Write(Summ(m - 1, n));
}

int Summ(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + Summ(m, n);
        return res;
    }
}