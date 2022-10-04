using ConsoleApp4;

Point point1 = new Point(4, 5, "1");
Point point2 = new Point(5, 6, "2");
Point point3 = new Point(8, 3, "3");
Point point4 = new Point(7, 6, "4");

Figure figure = new Figure(point1, point2, point3, point4);
Console.WriteLine(figure.GetName());
Console.WriteLine(figure.PerimetrCalculator());