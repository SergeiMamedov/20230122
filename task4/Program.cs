// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

int InputInt(string msg)
{
    System.Console.WriteLine(msg);
    int g = Convert.ToInt32(Console.ReadLine());
    return g;
}
int a = InputInt("Введите число");
int b = 7;
int c = 23;
if (a % b == 0 && a % 23 == 0)
{
    System.Console.WriteLine($"Число {a} кратно {b} и {c}");
}
else 
{
    System.Console.WriteLine($"Число {a} не кратно {b} и {c}");
}