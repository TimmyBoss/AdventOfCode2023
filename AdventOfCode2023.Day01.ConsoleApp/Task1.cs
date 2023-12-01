using AdventOfCode2023.Shared;

namespace AdventOfCode2023.Day01.ConsoleApp
{
    public class Task1 : ITask
    {
        private List<string> _puzzleInput = new List<string>();

        public string GetAnswer1()
        {
            long total = 0;
            foreach (string row in _puzzleInput)
            {
                List<char> numbers = row.Where(char.IsDigit).ToList();
                var number = numbers[0].ToString() + numbers[numbers.Count - 1].ToString();

                total += Convert.ToInt32(number);
            }

            return total.ToString();
        }

        public string GetAnswer2()
        {
            //   var sorted = _totalCaloriesList.OrderByDescending(t => t).Take(3);
            //     return sorted.Sum().ToString();
            return "Henk";
        }

        public void SetupPuzzleInput(List<string> puzzleInput)
        {
            _puzzleInput = puzzleInput;
        }
    }
}
