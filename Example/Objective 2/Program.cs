//По заданному номеру дня недели вывести его название
Console.Write("Введите номер дня недели: ");
int userNumber = int.Parse(Console.ReadLine());
if (userNumber == 1)
{
    Console.Write("Понедельник");
}
if (userNumber == 2)
{
    Console.Write("Вторник");
}
if (userNumber == 3)
{
    Console.Write("Среда");
}
if (userNumber == 4)
{
    Console.Write("Четверг");
}
if (userNumber == 5)
{
    Console.Write("Пятница");
}
if (userNumber == 6)
{
    Console.Write("Суббота");
}
if (userNumber == 7)
{
    Console.Write("Воскресенье");
}
