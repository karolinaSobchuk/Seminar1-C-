// Показать числа от -n до n
Console.Write ("Введите размер списка: ");
int a = int.Parse(Console.ReadLine());
int x = -a;

while (x <= a)
{
    Console.Write (x + " ");
    x++;
}