namespace AdventOfCode2023.Day02.ConsoleApp
{
    public class Set : List<Cubes>
    {
        public bool IsPossible(Bag bag)
        {
            foreach (var cubes in this)
            {
                var cubesInBag = bag.GetByColor(cubes.Color);

                if (cubesInBag == null || cubesInBag.Amount < cubes.Amount)
                    return false;
            }

            return true;
        }
    }
}
