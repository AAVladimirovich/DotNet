// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.Clear();

Console.WriteLine("Введите число: ");

int a = int.Parse(Console.ReadLine());
// int k = 0;
string num = " ";

// int Decimal(int a)
// {
//     int k =0;
//     if (a == 0) return;
    
//     if (a > 0) 
//     {
//         a = a % 2;
//         k = a % 2;
//        Decimal(a);
//        Console.Write($"{a}");
//     }

    
// }

int TenToTwo(int n)
{
    if (n == 1) return 1;
    if (n == 0) return 0;
    return n%2+10*TenToTwo(n/2);
}


//TenToTwo(a);

Console.WriteLine(TenToTwo(a));
