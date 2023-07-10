namespace LongestIncreasingSubsequence
{
    internal class Program
    {
        public static void Main()
        {
            int[] nums = { 10, 9, 2, 5, 3, 7, 101, 18 };
            int result = LongestIncreasingSubsequence(nums);
            Console.WriteLine(result);
        }

        public static int LongestIncreasingSubsequence(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            int[] dp = new int[nums.Length];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = 1;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
            }

            int max = 0;
            for (int i = 0; i < dp.Length; i++)
            {
                max = Math.Max(max, dp[i]);
            }

            return max;
        }
    }
}