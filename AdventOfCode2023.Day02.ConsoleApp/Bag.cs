namespace AdventOfCode2023.Day02.ConsoleApp
{
    public class Bag
    {
        public Bag()
        {
            Cubes = new List<Cubes>();
            Cubes.Add(new Cubes(12, "red"));
            Cubes.Add(new Cubes(13, "green"));
            Cubes.Add(new Cubes(14, "blue"));
        }

        public List<Cubes> Cubes { get; }

        public Cubes? GetByColor(string color) => Cubes.FirstOrDefault(c => c.Color == color);
    }
}
