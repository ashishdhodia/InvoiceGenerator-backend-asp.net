namespace InvoiceGenerator.Models
{
    public class Fee
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public decimal FinalAmount { get; set; }
    }
}
