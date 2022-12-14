// Программа, которая задаёт массив
// из 8 элементов и выводит их на экран

void FillArray(int[] numbers)
{
    int length = numbers.Length;

    for (int index = 0; index < length; index++)
    {
        numbers[index] = new Random().Next(-10000, 10000);
    }
}

// void PrintArray(int[] num)
// {
//     int length1 = num.Length;

//     for (int position = 0; position < (length1 - 1); position++)
//     {
//         Console.Write($"{num[position]}   ");
//     }
    
// }


// А если нужно через запятую и с {}

void PrintArray(int[] num)
{
    int length1 = num.Length;
    int position = 0;
    Console.Write("{ ");

    while (position < (length1 - 1))
    {
        Console.Write($"{num[position]}, ");
        position++;
    }
    Console.WriteLine(num[position] + " }");
}

int[] array = new int[8];

FillArray(array);

PrintArray(array);

// Задача на 2 массива и их слияние

void FillMas(int[] massive)

{
    int Length1_mas = massive.Length;
    
    for(int indexx = 0; indexx < Length1_mas; indexx++)
    {
        Console.Write("Введите число: ");
        int number_mas = Convert.ToInt32(Console.ReadLine());
        massive[indexx] = number_mas;
    }
}

void PrintMas(int[] massive2)
{
    int length_mas = massive2.Length;
    int position = 0;
   
    while (position < (length_mas - 1))
    {
        Console.Write($"{massive2[position]}, ");
        position++;
    }
    Console.Write(massive2[position]);
}

Console.Write("Введите длину 1 массива: ");
int count1 = Convert.ToInt32(Console.ReadLine());

int[] array1 = new int[count1];
FillMas(array1);

Console.Write("Введите длину 2 массива: ");
int count2 = Convert.ToInt32(Console.ReadLine());

int[] array2 = new int[count2];
FillMas(array2);

Console.Write("{");
PrintMas(array1);
Console.Write(", ");
PrintMas(array2);
Console.WriteLine("}");


// Как раннее прописывали

Console.Write("Введите длину 1 массива: ");
int count_number1 = Convert.ToInt32(Console.ReadLine());

int[] array11 = GetArray(count_number1);
Console.WriteLine($"[{String.Join(",", array11)}]");


Console.Write("Введите длину 2 массива: ");
int count_number2 = Convert.ToInt32(Console.ReadLine());

int[] array22 = GetArray(count_number2);
Console.WriteLine($"[{String.Join(",", array22)}]");

Console.WriteLine($"Новый массив [{String.Join(", ", array11)}, {String.Join(", ", array22)}]");

int[] GetArray(int size)
{
    int[] result_mas = new int[size];
    for (int ind = 0; ind < size; ind++)
    {
        Console.Write("Введите число: ");
        int res_number = Convert.ToInt32(Console.ReadLine());
        result_mas[ind] = res_number;
    }

    return result_mas;
}