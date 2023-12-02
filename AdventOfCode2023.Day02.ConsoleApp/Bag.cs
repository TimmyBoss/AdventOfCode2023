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

        public List<Cubes> Cubes { get; private set; }

        public Cubes? GetByColor(string color) => Cubes.FirstOrDefault(c => c.Color == color);

        public void GetMinimalBagByGame(Game game)
        {
            Cubes = new List<Cubes>();
            Cubes.Add(new Cubes(1, "red"));
            Cubes.Add(new Cubes(1, "green"));
            Cubes.Add(new Cubes(1, "blue"));

            foreach (var set in game.Sets)
            {
                foreach (var cubes in set)
                {
                    SetAmountForColor(cubes);
                }
            }
        }

        private void SetAmountForColor(Cubes cubes)
        {
            var redCubes = Cubes.FirstOrDefault(c => c.Color == "red");
            if (redCubes != null && redCubes.Amount < cubes.Amount && cubes.Color == "red")
                redCubes.SetAmount(cubes.Amount);

            var greenCubes = Cubes.FirstOrDefault(c => c.Color == "green");
            if (greenCubes != null && greenCubes.Amount < cubes.Amount && cubes.Color == "green")
                greenCubes.SetAmount(cubes.Amount);

            var blueCubes = Cubes.FirstOrDefault(c => c.Color == "blue");
            if (blueCubes != null && blueCubes.Amount < cubes.Amount && cubes.Color == "blue")
                blueCubes.SetAmount(cubes.Amount);

        }
    }
}
