using System;
class ElectricityBill {
    static void Main() {
        Console.Write("Enter unit price: ");
        double unitPrice = double.Parse(Console.ReadLine());

        Console.Write("Enter total consumption: ");
        double consumption = double.Parse(Console.ReadLine());

        Console.Write("Enter extra load: ");
        double extra = double.Parse(Console.ReadLine());

        double bill = (unitPrice * consumption) + extra;
        Console.WriteLine($"Total Bill: ₹{bill}");
    }
}
