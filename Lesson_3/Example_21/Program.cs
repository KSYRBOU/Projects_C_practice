// Программа принимает на вход координаты двух
// точек и находит расстояние между ними в 3D пространстве.

int[] Dot_1 = new int[3];
int[] Dot_2 = new int[3];

Console.WriteLine("Enter coordinates of first dot:");
Console.WriteLine("Enter x1:");
Dot_1[0] = int.Parse(Console.ReadLine());
Console.WriteLine("Enter y1:");
Dot_1[1] = int.Parse(Console.ReadLine());
Console.WriteLine("Enter z1:");
Dot_1[2] = int.Parse(Console.ReadLine());
Console.WriteLine("Enter coordinates of second dot");
Console.WriteLine("Enter x2:");
Dot_2[0] = int.Parse(Console.ReadLine());
Console.WriteLine("Enter y2:");
Dot_2[1] = int.Parse(Console.ReadLine());
Console.WriteLine("Enter z2:");
Dot_2[2] = int.Parse(Console.ReadLine());

Double Distance = Convert.ToDouble(Math.Sqrt(Math.Pow((Dot_2[0] - Dot_1[0]), 2) + Math.Pow((Dot_2[1] - Dot_1[1]), 2) + Math.Pow((Dot_2[2] - Dot_1[2]), 2)));

Console.WriteLine("Distance between dots: " + Distance);
