using AdventOfCode2023.Shared;

namespace AdventOfCode2023.Day03.ConsoleApp
{
    internal class DayTask : ITask
    {
        private char[,] _grid;
        private List<int> _partNumbers = new List<int>();


        public string GetAnswer1()
        {
            var number = "";
            List<bool> isLinkedToSymbol = new List<bool>();

            for (int i = 0; i < _grid.GetLength(0); i++)
                for (int j = 0; j < _grid.GetLength(1); j++)
                {
                    if (char.IsDigit(_grid[i, j]))
                    {
                        number += _grid[i, j];

                        isLinkedToSymbol.Add(IsLinkedToSymbol(i, j));

                        if (j == _grid.GetLength(1) - 1 || !char.IsDigit(_grid[i, j + 1]))
                        {
                            if (isLinkedToSymbol.Any(i => i))
                                _partNumbers.Add(Convert.ToInt32(number));

                            isLinkedToSymbol = new List<bool>();
                            number = "";
                        }
                    }
                }

            return _partNumbers.Sum(n => n).ToString();
        }


        public bool IsLinkedToSymbol(int i, int j)
        {
            if (j < _grid.GetLength(1) - 1 && !char.IsDigit(_grid[i, j + 1]) && _grid[i, j + 1] != '.')
                return true;
            if (j > 0 && !char.IsDigit(_grid[i, j - 1]) && _grid[i, j - 1] != '.')
                return true;
            if (i > 0 && !char.IsDigit(_grid[i - 1, j]) && _grid[i - 1, j] != '.')
                return true;
            if (i > 0 && j > 0 && !char.IsDigit(_grid[i - 1, j - 1]) && _grid[i - 1, j - 1] != '.')
                return true;
            if (j < _grid.GetLength(1) - 1 && i > 0 && !char.IsDigit(_grid[i - 1, j + 1]) && _grid[i - 1, j + 1] != '.')
                return true;
            if (i < _grid.GetLength(0) - 1 && !char.IsDigit(_grid[i + 1, j]) && _grid[i + 1, j] != '.')
                return true;
            if (i < _grid.GetLength(0) - 1 && j > 0 && !char.IsDigit(_grid[i + 1, j - 1]) && _grid[i + 1, j - 1] != '.')
                return true;
            if (j < _grid.GetLength(1) - 1 && i < _grid.GetLength(0) - 1 && !char.IsDigit(_grid[i + 1, j + 1]) && _grid[i + 1, j + 1] != '.')
                return true;

            return false;
        }


        public bool HasSequentialNumber(int i, int j)
        {
            if (char.IsDigit(_grid[i, j + 1]))
                return true;

            return false;
        }


        public string GetAnswer2()
        {
            return "";
        }

        public void SetupPuzzleInput(List<string> puzzleInput)
        {
            _grid = new char[puzzleInput.Count, puzzleInput[0].Length];

            for (int i = 0; i < puzzleInput.Count; i++)
                for (int j = 0; j < puzzleInput[i].Length; j++)
                    _grid[i, j] = puzzleInput[i].ToCharArray()[j];
        }
    }
}
