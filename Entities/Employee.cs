namespace GasStation.Entities
{
    internal class Employee
    {
        public int Id { get; set; }
        public required string FIO { get; set; }
        public required string PhoneNumber { get; set; }
        public required Role Role { get; set; } = null!;

    }
}
