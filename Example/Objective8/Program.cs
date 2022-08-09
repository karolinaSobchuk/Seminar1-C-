// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(10,99);

int a = number / 10;
int b = number % 10;

Console.WriteLine("Число из отрезка: " + number);
if (a>b)
{
   Console.WriteLine("Наибольшая цифра " + a);
}
else
{
    Console.WriteLine("Наибольшая цифра " + b);
}

