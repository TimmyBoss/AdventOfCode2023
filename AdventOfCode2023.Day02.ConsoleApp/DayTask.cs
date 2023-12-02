using AdventOfCode2023.Shared;

namespace AdventOfCode2023.Day02.ConsoleApp
{
    internal class DayTask : ITask
    {
        private List<Game> _games = new List<Game>();

        public string GetAnswer1()
        {
            var bag = new Bag();
            var totalAmount = 0;

            foreach (var game in _games)
            {
                if (game.IsPossible(bag))
                    totalAmount += game.Order;
            }

            return totalAmount.ToString();
        }

        public string GetAnswer2()
        {
            return "";
        }

        public void SetupPuzzleInput(List<string> puzzleInput)
        {
            foreach (var row in puzzleInput)
            {
                var splittedGameAndSets = row.Split(": ");

                var gameOrder = Convert.ToInt32(splittedGameAndSets[0].Replace("Game ", ""));
                var splittedSets = splittedGameAndSets[1].Split("; ");

                var sets = new List<Set>();

                foreach (var item in splittedSets)
                {
                    var set = new Set();

                    var splittedCubes = item.Split(", ");

                    foreach (var cube in splittedCubes)
                    {
                        var splittedCube = cube.Split(' ');
                        var amount = Convert.ToInt32(splittedCube[0]);
                        var color = splittedCube[1];

                        set.Add(new Cubes(amount, color));
                    }

                    sets.Add(set);
                }

                var game = new Game(gameOrder, sets);
                _games.Add(game);
            }
        }
    }
}
