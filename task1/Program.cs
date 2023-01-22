// Напишите программу, которая на вход принимает трехзначное чило и на выходе показывает последнюю цифру этого числа

int InputInt(string msg)
{
    System.Console.WriteLine(msg);
    int g = Convert.ToInt32(Console.ReadLine());
    return g;
}
int a = InputInt("Введите трехзначное число");
if (a > 99 && a < 1000)
{
    int result = a % 10;
    System.Console.WriteLine("Последняя цифра числа равна " + result);
}
else
{
    System.Console.WriteLine("Число не трехзначное");
}