var salespointsList = new SalePoint[200];
        
for (var i = 0; i < 200; i++)
{
    var rand = new Random().Next(100, 999);
    salespointsList[i] = new SalePoint()
    {
        salesPointName = "SalePointNameEpt",
        salesPointId = $"8b51a1c5-7294-4d0c-9ae5-21{rand}444ff28",
        cashboxes = new Cashbox[]
        {
            new Cashbox()
            {
                cashBoxRegNumber = "0000579109022552",
                cashBoxName = "sommennamme4cashbox",
                periods = Array.Empty<int>(),
                archive = false
            }
        }
    };
}
