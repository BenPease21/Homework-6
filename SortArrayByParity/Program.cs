using System.Security.Cryptography.X509Certificates;


///
/// `   This codes a little different than Leetcode;     `
/// 
/// I made my own way of testing to see if it would work, 
/// You can change the test value in "ListOfNums" on Line 52.
/// 
/// The "SortArrayByParity" method is Static becaue
/// Leetcode automatically makes a parrent object for it
/// 

namespace SortArrayByParity
{
    public class Solution
    {
        public static int[] SortArrayByParity(int[] nums)
        {
            int[] corrected = new int[nums.Length];
            int evenIndex = 0;
            int oddIndex = nums.Length - 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    corrected[evenIndex] = nums[i];
                    evenIndex++;
                }
                else
                {
                    corrected[oddIndex] = nums[i];
                    oddIndex--;
                }
            }

            return corrected;

        }

        public static string Write(int[] ints)
        {
            string msg = "{";

            foreach (int i in ints)
            {
                msg += $" {i} ";
            }    
            msg += "}";
            return msg;
        }



        static void Main()
        {
            int[] ListOfNums = {0};
            ListOfNums = SortArrayByParity(ListOfNums);
            string message = Write(ListOfNums);
            Console.WriteLine(message);


        }

    }
}
