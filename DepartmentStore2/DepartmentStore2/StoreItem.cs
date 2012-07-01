public class StoreItem
{
    public long itemNumber;
    public string itemName;
    public string size;
    public decimal unitPrice;

    public void CreateItem()
    {
        itemNumber = 911792;
        itemName = "Girls Tillie Poplin Dress";
        size = "12";
        unitPrice = 110.00m;
    }

    public decimal CalculateTotalValue(int qty)
    {
        return unitPrice * qty;
    }

    public void Describe()
    {
        int quantity = 6;

        System.Console.WriteLine("Department Store");

        System.Console.Write("Item #:      ");
        System.Console.WriteLine(itemNumber);
        System.Console.Write("Item Name:   ");
        System.Console.WriteLine(itemName);
        System.Console.Write("Item Size:   ");
        System.Console.WriteLine(size);
        System.Console.Write("Unit Price:  ");
        System.Console.WriteLine(unitPrice);
        System.Console.Write("Quantity:    ");
        System.Console.WriteLine(quantity);
        System.Console.Write("Total Value: ");
        System.Console.WriteLine(CalculateTotalValue(quantity));  
    }
}