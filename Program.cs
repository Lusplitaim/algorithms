using Algorithms.Search;
using Bogus;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var faker = new Faker();
            List<int> nums = new();
            for (int i = 0; i < 19; i++)
            {
                nums.Add(faker.Random.Int(1, 600));
            }

            var val = nums[3];
            Console.WriteLine($"Searching for {val}");

            nums.Sort();
            var arr = nums.ToArray();
            var idx = arr.TernarySearch(val);
            PrintArray(arr);
            Console.WriteLine($"Found at index [{idx}]");
        }

        static void PrintArray(int[] arr)
        {
            Console.Write("Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
