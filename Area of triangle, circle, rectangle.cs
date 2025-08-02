using System;
class AreaCalc {
    static void Main() {
        const double pi = 3.14;
        const double triangleBase = 5, triangleHeight = 10;

        double triangleArea = 0.5 * triangleBase * triangleHeight;
        double circleArea = pi * 4 * 4; // radius = 4
        double rectangleArea = 5 * 6;   // fixed dimensions

        Console.WriteLine($"Triangle Area: {triangleArea}");
        Console.WriteLine($"Circle Area: {circleArea}");
        Console.WriteLine($"Rectangle Area: {rectangleArea}");
    }
}
