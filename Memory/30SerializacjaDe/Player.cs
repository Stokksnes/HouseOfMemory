
namespace _30SerialziacjaDe
{
    internal class Player
    {
        public Player()
        {
        }

        public string Name { get; set; }
        public int Level { get; set; }

        public int HealthPoints { get; set; }
        public List<Statistics> Statistics { get; internal set; }
    }
}