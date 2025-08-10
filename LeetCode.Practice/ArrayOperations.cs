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

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (nums1.Length != m + n)
            {
                throw new Exception("nums1.Length should equal m + n");
            }

            for(int i = m;i < nums1.Length; i++)
            {
                nums1[i] = 1_000_000;
            }
           
            for(int j = 0; j < nums2.Length; j++)
            {
                var current = nums2[j];

                // where in nums1 does current sit find 

                for (int i =  0; i < nums1.Length; i++)
                {
                    if(current < nums1[i])
                    {
                        InsertIntoArray(nums1, i, current);
                        break;
                    }
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

        /*
        Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the 
        elements may be changed. Then return the number of elements in nums which are not equal to val.
        Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following 
        things:

        Change the array nums such that the first k elements of nums contain the elements which are not equal to val. 
        The remaining elements of nums are not important as well as the size of nums. 
        
        Return k.

        Input: nums = [3,2,2,3], val = 3
        Output: 2, nums = [2,2,_,_]
        Explanation: Your function should return k = 2, with the first two elements of nums being 2.
        It does not matter what you leave beyond the returned k (hence they are underscores).

        */

        public static int RemoveElement(int[] nums, int value)
        {
            int length = nums.Length;
            int numberOfValueFound = 0;

            for(int i = 0; i < length; i++)
            {
                if (nums[i] == value)
                {
                    // Move every element 1 step left to overwrite the value at i
                    for(int j = i; j < length - 1; j++)
                    {
                        nums[j] = nums[j + 1];
                    }

                    numberOfValueFound++;
                }
            }
                
            return nums.Length - numberOfValueFound;
        }


    }
}
