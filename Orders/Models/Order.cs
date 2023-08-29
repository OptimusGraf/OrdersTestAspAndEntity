namespace Orders.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string NameRecipient { get; set; } = null!;
        public string AdressSender { get; set; } = null!;
        public string AdressRecipient { get; set; } = null!;
        public string SitySender { get; set; } = null!;
        public string SityRecipient { get; set; } = null!;
        public int Weight { get; set; }
        public DateTime Date { get; set; } 

    }
}
