namespace LeetCode.Practice.Tests
{
    /*
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
    
    public class ArrayOperationsTests
    {
        [Fact]
        public void Test1()
        {
            int[] testData = [1, 2, 3, 4];
            ArrayOperations.InsertIntoArray(testData, 2, 7);

            Assert.Equal([1, 2, 7, 3], testData);
        }

        [Fact]
        public void Test2()
        {
            int[] testData = [1, 2, 0, 3, 4];
            ArrayOperations.DuplicateZeroesInPlace(testData);

            Assert.Equal([1, 2, 0, 0, 3], testData);
        }

        [Fact]
        public void Test3()
        {
            int[] testData = [0, 0, 0];
            ArrayOperations.DuplicateZeroesInPlace(testData);

            Assert.Equal([0, 0, 0], testData);
        }


        [Fact]
        public void Test4()
        {
            int[] testArray = [1, 5, 2, 0, 6, 8, 0, 6, 0];
            ArrayOperations.DuplicateZeroesInPlace(testArray);

            Assert.Equal([1, 5, 2, 0, 0, 6, 8, 0, 0], testArray);

        }

        [Fact]
        public void Test5()
        {
            int[] nums1 = [0];
            int m = 0;
            int[] nums2 = [1];
            int n = 1;

            ArrayOperations.Merge(nums1, m, nums2, n);

            Assert.Equal(nums1, [1]);
        }

        [Fact]
        public void Test6()
        {
            int[] nums1 = [1, 2, 3, 0, 0, 0];
            int m = 3;
            int[] nums2 = [2, 5, 6];
            int n = 3;

            ArrayOperations.Merge2(nums1, m, nums2, n);

            Assert.Equal([1, 2, 2, 3, 5, 6], nums1);
        }

        [Fact]
        public void Test7()
        {
            int[] nums1 = [1, 2, 3, 0, 0, 0];
            int m = 3;
            int[] nums2 = [2, 5, 6];
            int n = 3;

            ArrayOperations.Merge2(nums1, m, nums2, n);

            Assert.Equal(nums1, [1, 2, 2, 3, 5, 6]);
        }
    }
}