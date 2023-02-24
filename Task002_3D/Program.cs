// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// if - else if - else

// корень((х2-х1)^2 + (у2-у1)^2 + (z2 - z1)^2) = Формула нахождения расстояния между двумя точками в 3D

//A(x1;    y1)
Console.Write("Введите координату точки A по оси Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки  A по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки A по оси Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
// B(x2;    y2)
Console.Write("Введите координату точки B по оси Х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

// AB = √(x2 - x1)^2 + (y2 - y1)^2 + (z2 - z1)^2
// Math.Sqrt(25) => 5
// Math.Pow(число, степень) => Math.Pow(4, 2) => 4 возводите во 2 степень = 16
var result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
Console.WriteLine(Math.Round(result, 2)); 