using System;
class MiddleNumber {
    static void Main() {
        Console.Write("Enter three numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int middle = (a > b) ? ((a < c) ? a : (b > c ? b : c)) : ((b < c) ? b : (a > c ? a : c));
        Console.WriteLine($"Middle number: {middle}");
    }
}
