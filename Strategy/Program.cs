using Strategy;

var purchase1 = new Purchase
{
    Id = 1,
    Amount = 10m
};
var purschase2 = new Purchase
{
    Id = 2,
    Amount = 15m
};

var manager = new PurchaseManager([]);
manager.Add(purchase1);
manager.Add(purschase2);

manager.Pay(new VisaPaymentManager(), 1);
manager.Pay(new PaypalPaymentManager(), 2);