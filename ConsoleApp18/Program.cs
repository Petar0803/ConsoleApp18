namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3 };
            int[] nums2 = nums;
            nums[0] = 0;

            Console.WriteLine("Contents of nums2:");
            Console.WriteLine(string.Join(", ", nums2));

            Console.WriteLine("Loop through nums2:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"\t{nums2[i]}");
            }
        }
    }
}





