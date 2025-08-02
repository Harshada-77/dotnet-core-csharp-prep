using System;
class KmToMeter {
    static void Main() {
        Console.Write("Enter kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"In meters: {km * 1000}");
    }
}
