namespace Challenges.Day01_TwoSum;

public static class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        // sua implementação aqui
        var lookup = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (lookup.ContainsKey(complement))
            {
                return new int[] { lookup[complement], i };
            }
            lookup[nums[i]] = i;
        }

        throw new ArgumentException("No two sum solution", nameof(nums));
    }
}