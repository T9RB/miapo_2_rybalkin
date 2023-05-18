using Miapo_Rybalkin;

Functions functions = new();

string promit;
double a = 0;
double b = 0;

Console.WriteLine("Введите первое число: ");
a = double.Parse(Console.ReadLine() ?? string.Empty);

Console.WriteLine("Введите второе число: ");

b = double.Parse(Console.ReadLine() ?? string.Empty);

Console.WriteLine("Выберите функцию: 1. Плюс, 2. Минус");
promit = Console.ReadLine() ?? string.Empty;

if (promit == "1")
{
    //Вызов функции Plus с помощью try-catch
    try
    {
        Console.WriteLine($"Результат {functions.Plus(a, b)}");
    }
    catch(Exception e)
    {
        Console.WriteLine(e);
    }
}

else if (promit == "2")
{
    //Вызов функции Minus с помощью try-catch
    try
    {
        Console.WriteLine($"Результат {functions.Minus(a, b)}");
    }
    catch(Exception e)
    {
        Console.WriteLine(e);
    }
}


