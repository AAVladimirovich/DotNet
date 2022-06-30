// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.Clear();

Console.WriteLine("vvedite coordinati tochke");
Console.Write("X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

//if (X > 0 && Y > 0) Console.WriteLine("pervaya chetvert'");
// else if (X < 0 && Y > 0) Console.WriteLine("vtoraya chetvert'");
// else if (X < 0 && Y < 0) Console.WriteLine("tretya chetvert'");
// else if (X > 0 && Y < 0) Console.WriteLine("chetvertaya chetvert'");
// else Console.WriteLine("vvedeni nekorrektnie coordinati");

string Vooter(int in_X, int in_Y)
{
    if (in_X > 0 && in_Y > 0) return "pervaya chetvert'";
    else if (in_X < 0 && in_Y > 0) return "vtoraya chetvert'";
    else if (in_X < 0 && in_Y < 0) return "tretya chetvert'";
    else if (in_X > 0 && in_Y < 0) return "chetvertaya chetvert'";
    else return "vvedeni nekorrektnie coordinati";
}

string result = Vooter(X,Y);
Console.WriteLine(result);