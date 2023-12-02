namespace AdventOfCode2023.Day02.ConsoleApp
{
    public class Cubes(int amount, string color)
    {
        public int Amount { get; private set; } = amount;
        public string Color { get; } = color;

        public void SetAmount(int amount)
        {
            Amount = amount;
        }
    }
}
