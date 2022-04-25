namespace InvoiceGenerator.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int BusinessId { get; set; }
        public int ClientId { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DueDate { get; set; } = DateTime.Now.AddMonths(1);
        public decimal Tax { get; set; }
    }
}
