namespace LeetCode.Practice
{
    public class ContiguousArray
    {
        private List<int> _prefixSum = new List<int>();

        public ContiguousArray()
        {
        }

        public int FindMaxLength(int[] nums)
        {
            _prefixSum = new List<int>();

            int runningSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                runningSum += nums[i];
                _prefixSum.Add(runningSum);
            }

            /*
             Given a binary array nums, return the maximum length of a contiguous subarray with an equal 
             number of 0 and 1.

             1. Equal number of 0 and 1 implies it will be an even number
             2. The sum of such a segment will be half of its length when there is an equal number of 0 and 1
                01 = 1 length = 2
                0101 = 2 length = 4
                000111 = 3 length = 6
             3. Use the prefix sum array and look at every even numbereed length prefix 
                save each prefix sum where sum = half length
                pick the largest of the saved items

                Check each 2, 4, 6 8 length subarray within the array

                move start and end by 1 
                start with biggest even numbered sub arry and work down to the smallest.
             */
            var equal0And1List = new List<int>();
            var biggestEvenNumberedSubArray = (nums.Length % 2 == 0) ? nums.Length : nums.Length - 1;

            // Thsi covers the case where the sub array is the same length as the array
            if (_prefixSum.Count == biggestEvenNumberedSubArray)
            {
                var sumOfSubArray = _prefixSum[biggestEvenNumberedSubArray - 1] - _prefixSum[0];
                if (sumOfSubArray == (biggestEvenNumberedSubArray) / 2 && ((biggestEvenNumberedSubArray) % 2 == 0))//half the length of prefix sum array
                {
                    equal0And1List.Add(biggestEvenNumberedSubArray);
                }
            }


            var counter = 0;
            do
            { 
                var lengthOfSubbary = (biggestEvenNumberedSubArray) - counter;

                int end = (lengthOfSubbary - 1) + 0;

                var sumOfSubArray = _prefixSum[end] - _prefixSum[0];

                if (sumOfSubArray == (lengthOfSubbary) / 2 && ((lengthOfSubbary) % 2 == 0)) //half the length of prefix sum array
                {
                    equal0And1List.Add(lengthOfSubbary);
                }

                for (int start = 1; start <= _prefixSum.Count - (lengthOfSubbary); start++)
                {
                    end = (lengthOfSubbary - 1) + start;

                    if (end >= _prefixSum.Count)
                        break;

                    sumOfSubArray = _prefixSum[end] - _prefixSum[start - 1];

                    if ((sumOfSubArray == (lengthOfSubbary) / 2) && (lengthOfSubbary % 2 == 0) ) //half the length of prefix sum array
                    {
                        equal0And1List.Add(lengthOfSubbary);
                    }
                }

                counter++;

                if (counter > _prefixSum.Count)
                    break;
            }
            while (equal0And1List.Count == 0);

            return equal0And1List.Max();
        }
    }
}
