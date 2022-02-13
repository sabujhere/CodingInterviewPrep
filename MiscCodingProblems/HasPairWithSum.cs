namespace MiscCodingProblems
{
    /*
     * The question goes as follows:
        Given a collection of numbers and a number target, find a matching pair that is equal to a given target.
        If there is a matching sum, return true, otherwise, return false .

        For example:

        Input: nums = [1,2,3,9], target = 8
        Output: false
        Output: No matching pair


        Input: nums = [1,2,4,4], target = 8
        Output: true
        Output: Matching pair found nums[2] + nums[3] = 8
     */
    public class HasPairWithSum
    {
        public bool GetSumNaive(int[] data, int sum)
        {
            for (int i = 0; i < data.Length-1; i++)
            {
                for (int j = i+1; j < data.Length; j++)
                {
                    var currentSum = data[i] + data[j];
                    if ( currentSum == sum) return true;
                }
            }
            return false;
        }

        public bool GetSumBetter(int[] data, int sum)
        {
            var complementedSet = new HashSet<int>();
            for (int i = 0; i < data.Length; i++)
            {
                if(complementedSet.Contains(data[i])) return true;
                complementedSet.Add(sum - data[i]);
            }
            return false;
        }
    }
}