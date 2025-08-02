using System;
class SalaryCalc {
    static void Main() {
        Console.Write("Enter Basic Salary: ");
        double basic = Convert.ToDouble(Console.ReadLine());
        double ta = basic * 0.1;
        double da = basic * 0.2;
        double pf = basic * 0.05;
        double hra = basic * 0.15;

        Console.Write("Enter number of leaves taken: ");
        int leaves = int.Parse(Console.ReadLine());
        double leaveDeduction = leaves * 100; // assuming ₹100 per leave

        double totalSalary = basic + ta + da + hra - pf - leaveDeduction;
        Console.WriteLine($"Total Salary: {totalSalary}");
    }
}
