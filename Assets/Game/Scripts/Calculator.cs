using System.Collections.Generic;

namespace Game
{
    public class Calculator
    {
        public int FindSumBetweenFirstAndLastNegativeElement(List<int> numbers)
        {
            int firstNegativeIndex = -1;
            int lastNegativeIndex = -1;
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    firstNegativeIndex = i;
                    break;
                }
            }

            if (firstNegativeIndex == -1)
                return -1;

            for (int i = numbers.Count - 1; i >= 0; i++)
            {
                if (numbers[i] < 0)
                {
                    lastNegativeIndex = i;
                    break;
                }
            }

            for (int i = firstNegativeIndex + 1; i < lastNegativeIndex; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
