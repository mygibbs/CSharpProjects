using System;

public class Program
{
    static int Main()
    {
        StoreItem si = new StoreItem();

        si.itemNumber = 660284;
        si.itemName = "Tropical Wool Neutral Jacket";
        si.unitPrice = 200.00M;

        Console.WriteLine("Store Inventory");
        Console.Write("Item #:     ");
        Console.WriteLine(si.itemNumber);
        Console.Write("Item Name:  ");
        Console.WriteLine(si.itemName);
        Console.Write("Unit Price: ");
        Console.WriteLine(si.unitPrice);
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        System.Console.ReadKey();
        return 0;
    }
}