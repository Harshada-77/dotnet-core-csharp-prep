using System;
class Conversion {
    static void Main() {
        Console.Write("Enter value in feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"In inches: {feet * 12}");

        Console.Write("Enter value in inches: ");
        double inch = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"In feet: {inch / 12}");
    }
}
