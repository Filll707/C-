/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 
*/

Console.WriteLine("Введите координаты первой точки в 3D пространстве (X,Y,Z)");
double pointAX = Convert.ToInt32(Console.ReadLine());
double pointAY = Convert.ToInt32(Console.ReadLine());
double pointAZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите координаты второй точки в трехмерном пространстве (X,Y,Z)");
double pointBX = Convert.ToInt32(Console.ReadLine());
double pointBY = Convert.ToInt32(Console.ReadLine());
double pointBZ = Convert.ToInt32(Console.ReadLine());

double distanceBetweenPoints = 0;

distanceBetweenPoints = Math.Sqrt(Math.Pow(pointBX - pointAX, 2) + Math.Pow(pointBY - pointAY, 2) + Math.Pow(pointBZ - pointAZ, 2));

System.Console.WriteLine($"Расстояние между точками равно {Math.Round(distanceBetweenPoints, 2)}");
