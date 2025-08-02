using System;
class DecimalToBinary {
    static void Main() {
        Console.Write("Enter decimal number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Binary: " + Convert.ToString(num, 2));
    }
}
