namespace BuildArrayFromPermutation
{

    public class Solution
    {
        public int[] BuildArray(int[] nums)
        {
            int[] newArray = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                newArray[i] = nums[nums[i]];
            }
            return newArray;
        }
    }
    public static class Program
    {
        public static void Main()
        {
            int[] nums = { 0, 2, 1, 5, 3, 4 };
            Solution solution = new Solution();
            int[] result = solution.BuildArray(nums);
            Console.WriteLine(string.Join(",", result));
        }
    }
}