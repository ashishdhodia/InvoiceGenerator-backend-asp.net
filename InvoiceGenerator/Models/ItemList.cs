namespace InvoiceGenerator.Models
{
    public class ItemList
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public string? ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    }
}
