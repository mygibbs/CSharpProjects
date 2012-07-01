public class DepartmentStore
{
    static int Main()
    {
        StoreItem si = new StoreItem();

        si.CreateItem();
        si.Describe();

        System.Console.ReadKey();

        return 0;
    }
}