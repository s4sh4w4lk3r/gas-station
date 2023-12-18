namespace GasStation.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
        public Employee Employee { get; set; } = null!;
        public DateTime DateTime { get; set; }
        public decimal Total { get; set; }

    }
}
