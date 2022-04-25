namespace InvoiceGenerator.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string? ClientName { get; set; }
        public string? ClientAddress { get; set; }
        public string? ClientCity { get; set; }
        public string? ClientState { get; set; }
        public int ClientPhoneNumber { get; set; }
    }
}
