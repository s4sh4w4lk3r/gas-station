namespace GasStation
{
    internal class Program
    {
        static void Main(string[] args)

        {
            new GasContext().Database.EnsureDeleted();
            new GasContext().Database.EnsureCreated();
        }
    }
}
