namespace edilData.Models
{
    public class Payment
    { 
        public int IdPayment { get; set; }
        public DateOnly PaymentPeriod { get; set; }
        public double PaymentAmount { get; set; }
        public string PaymentType { get; set; }

    }
}
