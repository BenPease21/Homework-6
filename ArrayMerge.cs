public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;     // i = length of 1st array minus 1
        int j = n - 1;     // j = length of 2nd array minus 1
        int k = m + n - 1; // k = length of 1st and 2nd array minus 1

        while (i >= 0 && j >= 0)
        {
            if (nums1[i] > nums2[j])
            {
                nums1[k] = nums1[i];
                i--;
            } //bleh
            else
            {
                nums1[k] = nums2[j];
                j--;
            }
            k--;
        }

        while (j >= 0)
        {
            nums1[k] = nums2[j];
            j--;
            k--;
        }

    }

    static void Main()
    {
        Solution solution = new Solution();
        int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
        int[] nums2 = new int[] { 2, 5, 6 };
        solution.Merge(nums1, 3, nums2, 3);
        foreach (int item in nums1)
        {
            Console.WriteLine(item);
        }



    }
    
}