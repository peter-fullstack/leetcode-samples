namespace LeetCode.Practice.Tests
{
    public class TwoSumSolutionTests
    {
        [Fact]
        public void Test1()
        {
            int[] testData = [2, 7, 11, 15];
            var rangeSum = new TwoSumSolution();

            var result = rangeSum.TwoSum(testData, 9);

            Assert.Equal([1, 2], result);
        }

        [Fact]
        public void Test2()
        {
            int[] testData = [2, 3, 4];
            var rangeSum = new TwoSumSolution();

            var result = rangeSum.TwoSum(testData, 6);

            Assert.Equal([1, 3], result);
        }

        [Fact]
        public void Test3()
        {
            int[] testData = [-1, 0];
            var rangeSum = new TwoSumSolution();

            var result = rangeSum.TwoSum(testData, -1);

            Assert.Equal([1, 2], result);
        }
    }
}