//Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите целое число: ");
int Number1 = int.Parse(Console.ReadLine()!);
int Number2 = Number1 * -1;
int temp;

if(Number1 < 1)
{
    temp = Number1;
    Number1 = Number2;
    Number2 = temp;
}
while(Number2 <= Number1)
{
    Console.Write(Number2 + " ");
    Number2 += 1;
}
