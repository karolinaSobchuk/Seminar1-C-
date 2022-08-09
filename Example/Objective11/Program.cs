// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите  число: ");
int Number1 = int.Parse(Console.ReadLine());

if (Number1 % 100 > 0)
{
    Console.WriteLine (" Третье число будет равно: " (Number1 % 100 / 10) );
}
else
{
    Console.WriteLine (" Третье число отсутствует ");
}