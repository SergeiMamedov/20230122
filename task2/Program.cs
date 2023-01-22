// Напишите программу, которая выводит случайное число из отрезка и показывает наибольшую цифру этого числа

int a = new Random().Next(10, 100);
System.Console.WriteLine($"Сравниваем цифры в {a}");
int b = a / 10;
int c = a % 10;
if (b > c)
{
    System.Console.WriteLine($"Больше {b}");
}
else
{
    System.Console.WriteLine($"Больше {c}");
}