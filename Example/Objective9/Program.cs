// Удалить вторую цифру трёхзначного числа
int number = int.Parse(Console.ReadLine());

int a = number % 10;
int b = number / 100;
int res = b * 10 + a;

Console.WriteLine("Трехзначное число с удалением второй цифры: " + res);
