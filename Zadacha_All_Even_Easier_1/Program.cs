// На вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число, большее 1: ");
int N = Convert.ToInt32(Console.ReadLine());
int evennumber = 2;

// Это упрощённый вариант без запятых

if(N > 1)

{
    while(evennumber <= N)     // [1,N], т.е. включительно
    {
        Console.Write(evennumber + " ");
        evennumber = evennumber + 2;
    }
}
else
{
    Console.WriteLine("Ваше число не подходит условию задачи, невозможно определить чётные числа [1,N]");
}