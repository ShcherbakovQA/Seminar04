// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.

int HaveNumberA()
{
    Console.WriteLine("Введите число А");
    return Convert.ToInt32(Console.ReadLine());
}
int HaveNumberB()
{
    Console.WriteLine("Введите число В");
    return Convert.ToInt32(Console.ReadLine());
}
int ExtentNum(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}
int A = HaveNumberA();
int B = HaveNumberB();

Console.WriteLine("Число " + A + " в степени "  + B +  " = " + ExtentNum(A,B));






