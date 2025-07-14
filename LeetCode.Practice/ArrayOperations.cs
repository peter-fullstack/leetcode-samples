namespace LeetCode.Practice
{
    public class ArrayOperations
    {
        /*
        You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two 
        integers m and n, representing the number of elements in nums1 and nums2 respectively.
        
        Merge nums1 and nums2 into a single array sorted in non-decreasing order.
        The final sorted array should not be returned by the function, but instead be stored inside 
        the array nums1. 
        
        To accommodate this, nums1 has a length of m + n, where the first m 
        elements denote the elements that should be merged, and the last n elements are set 
        to 0 and should be ignored. nums2 has a length of n.
        
        Example 1:

        Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
        Output: [1,2,2,3,5,6]
        Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
        The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
        Example 2:

        Input: nums1 = [1], m = 1, nums2 = [], n = 0
        Output: [1]
        Explanation: The arrays we are merging are [1] and [].
        The result of the merge is [1].
        Example 3:

        Input: nums1 = [0], m = 0, nums2 = [1], n = 1
        Output: [1]
        Explanation: The arrays we are merging are [] and [1].
        The result of the merge is [1].
        Note that because m = 0, there are no elements in nums1. The 0 is only there to ensure 
        the merge result can fit in nums1.
        */

        public static void Merge2(int[] nums1, int m, int[] nums2, int n)
        {
            if(nums1.Length != m + n)
            {
                throw new Exception("nums1.Length should equal m + n");
            }

            var list = new List<int>();

            int j = 0;
            for (int i = 0; i < m && j < n; i++, j++)
            {
                if (i > nums1.Length - 1)
                {
                    break;
                }

                if (nums1[i] <= nums2[j])
                {
                    list.Add(nums1[i]);
                    list.Add(nums2[j]);
                }
                else
                {
                    list.Add(nums2[j]);
                    list.Add(nums1[i]);
                }
            }

            nums1 = list.ToArray();
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (m < n)
            {
                int j = 0;
                for (int i = 0; i < m; i++)
                {
                    if (nums1[i] > nums2[j])
                    {
                        InsertIntoArray(nums1, i, nums2[j]);
                        InsertIntoArray(nums1, i + 1, nums1[i]);
                    }
                    else
                    {
                        InsertIntoArray(nums1, i, nums1[i]);
                        InsertIntoArray(nums1, i + 1, nums2[j]);
                    }
                    j++;
                    i++;
                }

                for(int i = 0; i < n; i++)
                {
                    nums1[m + i] = nums2[i];
                }
            }
            else
            {
                int j = 0;
                for (int i = 0; i < n; i++)
                {
                    if (nums1[i] > nums2[j])
                    {
                        InsertIntoArray(nums1, i, nums2[j]);
                        InsertIntoArray(nums1, i + 1, nums1[i]);
                    }
                    else
                    {
                        InsertIntoArray(nums1, i, nums1[i]);
                        InsertIntoArray(nums1, i + 1, nums2[j]);
                    }
                    j++;
                }

                for (int i = 0; i < m; i++)
                {
                    nums1[n + i] = nums2[i];
                }
            }
        }

        public static void DuplicateZeroesInPlace(int[] array)
        {
            var jump = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    break;
                }

                if (array[i] == 0 && !jump)
                {
                    InsertIntoArray(array, i + 1, 0);
                    jump = true;
                }
                else
                {
                    jump = false;
                }
            }
        }


        public static void InsertIntoArrayInPlace(int[] array, int index, int value)
        {
            var newArray = array;

            for (int j = 0; j < index; j++)
            {
                array[j] = newArray[j];
            }

            for (int i = newArray.Length - 1; i >= index; i--)
            {
                // Shift each element one position to the right.
                if (i <= array.Length - 2)
                {
                    array[i + 1] = newArray[i];
                }
            }

            // Now that we have created space for the new element,
            // we can insert it at the required index.
            if (index < array.Length)
            {
                array[index] = value;
            }
        }
        public static void InsertIntoArray(int[] array, int index, int value)
        {
            var newArray = array;

            for (int j = 0; j < index; j++)
            {
                array[j] = newArray[j];
            }

            for (int i = newArray.Length - 1; i >= index; i--)
            {
                // Shift each element one position to the right.
                if (i <= array.Length - 2)
                {
                    array[i + 1] = newArray[i];
                }
            }

            // Now that we have created space for the new element,
            // we can insert it at the required index.
            if (index < array.Length)
            {
                array[index] = value;
            }
        }
    }
}
