/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("Введите первое значение");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение");
int n = Convert.ToInt32(Console.ReadLine());

AkkerFunction(m, n);

void AkkerFunction(int m, int n)
{
    Console.Write(Akker(m, n));
}

int Akker(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0)
    {
        return Akker(m - 1, 1);
    }
    else
    {
        return (Akker(m - 1, Akker(m, n - 1)));
    }
}