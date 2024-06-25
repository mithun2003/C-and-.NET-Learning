

namespace ConcatenationOfArray
{
    public class Concatenator
    {
        public int[] GetConcatenation(int[] nums)
        {
            int[] arr = new int[2 * nums.Length];
            for (int i = 0; i < nums.Length  * 2; i++)
            {
                arr[i] = nums[i % nums.Length];

            }
            return arr;
        }
    }

    public static class Program
    {
        public static void Main()
        {
            int[] inputArray = { 1, 2, 3 };
            Concatenator concatenator = new Concatenator();
            int[] concatenatedArray = concatenator.GetConcatenation(inputArray);
            
            Console.WriteLine(concatenatedArray);
            Console.WriteLine(string.Join(",", concatenatedArray));
        }
    }
}