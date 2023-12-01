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
                var normalRow = Regex.Matches(row, @"one|two|three|four|five|six|seven|eight|nine|\d")
                    .Select(m => m.Value).ToArray();
                var reverseRow = Regex.Matches(GetReversedString(row), @"eno|owt|eerht|ruof|evif|xis|neves|thgie|enin|\d")
                    .Select(m => m.Value).ToArray();

                var firstItem = ReplaceWithDigit(normalRow[0]);
                var lastItem = ReplaceWithDigit(reverseRow[0]);
                var number = firstItem + lastItem;

                total += Convert.ToInt32(number);
            }

            return total.ToString();
        }

        private string GetReversedString(string row)
        {
            char[] stringArray = row.ToCharArray();
            Array.Reverse(stringArray);
            string reversedStr = new string(stringArray);
            return reversedStr;
        }

        private string ReplaceWithDigit(string value)
        {
            switch (value)
            {
                case "eno":
                case "one":
                    return "1";
                case "owt":
                case "two":
                    return "2";
                case "eerht":
                case "three":
                    return "3";
                case "ruof":
                case "four":
                    return "4";
                case "evif":
                case "five":
                    return "5";
                case "xis":
                case "six":
                    return "6";
                case "neves":
                case "seven":
                    return "7";
                case "thgie":
                case "eight":
                    return "8";
                case "enin":
                case "nine":
                    return "9";
                default: return value;
            }
        }

        public void SetupPuzzleInput(List<string> puzzleInput)
        {
            _puzzleInput = puzzleInput;
        }
    }
}
