using System;

class FuelApp
{
    static void Main()
    {
        double pricePerLiter;

        Console.Write("Enter price of gasoline per liter: ");
        pricePerLiter = Convert.ToDouble(Console.ReadLine());

        // Vehicle 1
        Console.WriteLine("\n--- Vehicle 1 ---");
        Console.Write("Enter mileage (km): ");
        double mileage1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter consumption (liters per km): ");
        double rate1 = Convert.ToDouble(Console.ReadLine());

        double cost1 = mileage1 * rate1 * pricePerLiter;

        // Vehicle 2
        Console.WriteLine("\n--- Vehicle 2 ---");
        Console.Write("Enter mileage (km): ");
        double mileage2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter consumption (liters per km): ");
        double rate2 = Convert.ToDouble(Console.ReadLine());

        double cost2 = mileage2 * rate2 * pricePerLiter;

        // Output results
        Console.WriteLine("\n--- Results ---");
        Console.WriteLine("Vehicle 1 Cost: " + cost1);
        Console.WriteLine("Vehicle 2 Cost: " + cost2);

        if (cost1 < cost2)
            Console.WriteLine("Vehicle 1 is more economical.");
        else if (cost2 < cost1)
            Console.WriteLine("Vehicle 2 is more economical.");
        else
            Console.WriteLine("Both vehicles cost the same.");
    }
}
