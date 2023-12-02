namespace AdventOfCode2023.Day02.ConsoleApp
{
    public class Game(int order, List<Set> sets)
    {
        public int Order { get; } = order;
        public List<Set> Sets { get; } = sets;

        public bool IsPossible(Bag bag) => Sets.All(s => s.IsPossible(bag));
    }
}
