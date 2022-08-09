// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите  число: ");
int Number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число для подсчета кратности: ");
int Number2 = int.Parse(Console.ReadLine());
int number = (Number1 % Number2);

if ( number == 0)
{
    Console.WriteLine (" Число кратно ");
}
else 
{
     Console.WriteLine($"Число {Number1} не кратно числу {Number2}, остаток от деления равен {Number1 % Number2}");
}

