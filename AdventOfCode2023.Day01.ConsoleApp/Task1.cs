using AdventOfCode2023.Shared;
using System.Text.RegularExpressions;

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
                if (numbers.Count > 0)
                {
                    var number = numbers[0].ToString() + numbers[numbers.Count - 1].ToString();
                    total += Convert.ToInt32(number);
                }
            }

            return total.ToString();
        }

        public string GetAnswer2()
        {
            int total = 0;

            foreach (string row in _puzzleInput)
            {
                var numbers = Regex.Matches(row, @"one|two|three|four|five|six|seven|eight|nine|\d")
                    .Select(m => m.Value).ToArray();

                var number = ReplaceWithDigit(numbers[0]) + ReplaceWithDigit(numbers[numbers.Length - 1]);

                //    Console.WriteLine(row + "  --  " + number);

                total += Convert.ToInt32(number);
            }

            return total.ToString();
        }

        private string ReplaceWithDigit(string value)
        {
            switch (value)
            {
                case "one": return "1";
                case "two": return "2";
                case "three": return "3";
                case "four": return "4";
                case "five": return "5";
                case "six": return "6";
                case "seven": return "7";
                case "eight": return "8";
                case "nine": return "9";
                default: return value;
            }
        }

        public void SetupPuzzleInput(List<string> puzzleInput)
        {
            _puzzleInput = puzzleInput;
        }
    }
}
