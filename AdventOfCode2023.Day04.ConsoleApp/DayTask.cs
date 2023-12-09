using AdventOfCode2023.Shared;

namespace AdventOfCode2023.Day04.ConsoleApp
{
    internal class DayTask : ITask
    {
        private readonly List<ScratchCard> _scratchCards = new List<ScratchCard>();
        private readonly List<ScratchCard> _winningScratchCards = new List<ScratchCard>();

        public string GetAnswer1()
        {
            var totalPoints = 0;

            foreach (var card in _scratchCards)
            {
                var cardPoints = 0;

                foreach (var userNumber in card.UserNumbers)
                    if (card.WinningNumbers.Contains(userNumber))
                    {
                        if (cardPoints >= 1)
                            cardPoints *= 2;
                        else
                            cardPoints++;
                    }

                totalPoints += cardPoints;
            }

            return totalPoints.ToString();
        }

        public string GetAnswer2()
        {
            foreach (var card in _scratchCards)
            {
                _winningScratchCards.Add(card);
                var cardsByNumber = _winningScratchCards.Where(w => w.CardNumber == card.CardNumber).ToList();

                foreach (var cardByNumber in cardsByNumber)
                    for (int i = card.CardNumber + 1; i <= card.CardNumber + card.AmountWon; i++)
                        _winningScratchCards.Add(_scratchCards.First(s => s.CardNumber == i));
            }

            return _winningScratchCards.Count().ToString();
        }

        public void SetupPuzzleInput(List<string> puzzleInput)
        {
            foreach (var input in puzzleInput)
                _scratchCards.Add(new ScratchCard(input));
        }
    }
}