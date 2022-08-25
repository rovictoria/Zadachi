// Программa, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27

Console.Write("Введите число >= 1: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;

if (N > 0) {
  while (i < N)
  {
    Console.Write(Math.Pow(i,3)+ ", ");
    i++;
  }
  if(i == N) {
    Console.Write(Math.Pow(i,3));
  }
} else {
    Console.WriteLine("Число не удовлетворяет условию, повторите ввод ");
}