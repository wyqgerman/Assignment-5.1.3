﻿namespace Assignment_5._1._3
{
    internal class Program
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> seen = new HashSet<int>();

            foreach (int num in nums)
            {
                if (seen.Contains(num))
                {
                    return true;
                }
                seen.Add(num);
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 1 };
            Console.WriteLine(ContainsDuplicate(nums1));

            int[] nums2 = { 1, 2, 3, 4 };
            Console.WriteLine(ContainsDuplicate(nums2));

            int[] nums3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            Console.WriteLine(ContainsDuplicate(nums3));
        }
    }
    }
}
