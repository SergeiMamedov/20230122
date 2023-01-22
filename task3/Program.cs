// Напишите программу, которая на вход принимает два числа и выводит является ли второе число кратным первому.
// Если число не является кратным, то вывести остаток от деления

int InputInt(string msg)
{
    System.Console.WriteLine(msg);
    int g = Convert.ToInt32(Console.ReadLine());
    return g;
}
int a = InputInt("Введите первое число: ");
int b = InputInt("Введите второе число: ");
if (a % b == 0)
{
    System.Console.WriteLine($"Число {b} кратно числу {a}");
}
else 
{
    System.Console.WriteLine($"Число {b} не кратно числу {a}, остаток {a % b}");
}
