namespace Strategy
{
    public class Purchase
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
    }

    public interface IPaymentManager
    {
        void Pay(Purchase purchase);
    }

    public class VisaPaymentManager : IPaymentManager
    {
        public void Pay(Purchase purchase) => Console.WriteLine("Paiement avec Visa");
    }

    public class PaypalPaymentManager : IPaymentManager
    {
        public void Pay(Purchase purchase) => Console.WriteLine("Paiement avec Paypal");
    }

    public enum PaymentMode
    {
        Visa,
        Paypal
    }

    public class PurchaseManager(ICollection<IPaymentManager> paymentManagers)
    {
        private List<Purchase> _purchases = [];

        public void Add(Purchase purchase)
        {
            _purchases.Add(purchase);
        }

        public void Pay(IPaymentManager paymentManager, int id)
        {
            var purchase = _purchases.Find(p => p.Id == id);
            if (purchase is not null)
                paymentManager.Pay(purchase);
        }
    }
}