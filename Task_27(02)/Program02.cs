// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

int HaveNumber()
{
    Console.WriteLine("Введите число");
    return Convert.ToInt32(Console.ReadLine());
}
int Len(int a)
{
    int i = 0;
    while (a != 0)
    {
        a = a / 10;
        i++;
    }
    return i;
}

int Sum(int a, int len)
{
    int result = 0;
    for (int i = 0; i <= len; i++)
    {
        result = result + (a % 10);
        a = a / 10;
    }
    return result;
}
int N = HaveNumber();
Console.Write("Сумма цифр введенного числа = ");
Console.WriteLine(Sum(N, Len(N)));
