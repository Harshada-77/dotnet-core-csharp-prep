using System;
class SquareCube {
    static void Main() {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Square: {n * n}, Cube: {n * n * n}");
    }
}
