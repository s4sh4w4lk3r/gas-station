namespace GasStation.Entities
{
    internal class Delivery
    {
        public int Id { get; set; }
        public ICollection<Deliverer> Deliverers { get; set; } = new List<Deliverer>();
        public DateTime DateTime { get; set; }
        public required string CarNumber { get; set; }
    }
}
