using ConsoleApp3;
double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
Rectangle x = new Rectangle(a, b);
Console.WriteLine(x.Area.ToString() + " " + x.Perimeter.ToString());