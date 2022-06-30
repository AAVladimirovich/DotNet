// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("vvedite coordinati tochke");
Console.Write("X1: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("X2: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// double Y = Convert.ToDouble(Console.ReadLine());


// int result = Convert.ToInt32(X % 10);
// Console.WriteLine(result);
// int result1 = Convert.ToInt32(X/10);
// Console.WriteLine(result1);

// double Pifagor(int in_X1, int in_Y1, int in_X2, int in_Y2)
// {
//     return
// }


double result = Convert.ToDouble(Math.Sqrt((X1 - X2)*(X1 - X2) + (Y1-Y2)*(Y1-Y2)));
Console.WriteLine(Math.Round(result,2));

// string Voo(int in_X, int in_Y)
// {
// 2  sw1tc2 ((in_X, in_Y))
//     {
//         case ( > 0, > 0): return "pervaya chetvert"; break;
//         case ( < 0, > 0): return "vtoraya chetvert"; break;
//         case ( < 0, < 0): return "tretya chetvert"; break;
//         case ( > 0, < 0): return "chetvertaya chetvert"; break;
//         default: return "vvedeni nekorrektnie coordinati"; break;
//     }
// }

// // string result = Vooter(X, Y);
// // Console.WriteLine(result);