namespace HelloWorld.obj;

using Newtonsoft.Json;

public class SalePoint
{
    public string salesPointName { get; set; }

    public string salesPointId { get; set; }

    public Cashbox[] cashboxes { get; set; }
}

public class Cashbox
{
    public string cashBoxRegNumber { get; set; }
    public string cashBoxName { get; set; }
    public int[] periods { get; set; }
    public bool archive { get; set; }
}
