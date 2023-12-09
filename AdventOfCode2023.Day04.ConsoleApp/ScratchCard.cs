namespace AdventOfCode2023.Day04.ConsoleApp
{
    public class ScratchCard
    {
        public ScratchCard(string input)
        {
            string[] inputParts = input.Split(':');
            CardNumber = GetCardNumber(inputParts[0]);

            string[] inputNumberParts = inputParts[1].Split("|");
            WinningNumbers = GetNumberList(inputNumberParts[0]);
            UserNumbers = GetNumberList(inputNumberParts[1]);
        }

        public int CardNumber { get; set; }
        public List<int> WinningNumbers { get; set; }
        public List<int> UserNumbers { get; set; }

        public int AmountWon => UserNumbers.Count(w => WinningNumbers.Contains(w));

        public int GetCardNumber(string input)
        {
            int cardNumber = Convert.ToInt32(input.Replace("Card ", ""));
            return cardNumber;
        }

        public List<int> GetNumberList(string input)
        {
            var numbers = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var numberList = new List<int>();

            foreach (var number in numbers)
                numberList.Add(Convert.ToInt32(number));

            return numberList;
        }
    }
}
