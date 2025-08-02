using System;
class SimpleInterest {
    static void Main() {
        Console.Write("Enter Principal: ");
        int p = int.Parse(Console.ReadLine());

        const double r = 5;  // constant rate
        const double t = 2;  // constant time

        double si = (p * r * t) / 100;
        Console.WriteLine($"Simple Interest: {si}");
    }
}
