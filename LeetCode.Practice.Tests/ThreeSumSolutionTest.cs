namespace LeetCode.Practice.Tests
{
    public class ThreeSumSolutionTests
    {
        [Fact]
        public void Test1()
        {
            int[] testData = [-1, 0, 1, 2, -1, -4];
            var rangeSum = new ThreeSumSolution();

            var result = rangeSum.ThreeSum(testData);

            Assert.Equal([[-1, 2, -1], [-1, 0, 1]], result);
        }

        [Fact]
        public void Test2()
        {
            int[] testData = [2, 3, 4];
            var rangeSum = new ThreeSumSolution();

            var result = rangeSum.ThreeSum(testData);

            Assert.Equal([], result);
        }

        [Fact]
        public void Test3()
        {
            int[] testData = [0, 0, 0];
            var rangeSum = new ThreeSumSolution();

            var result = rangeSum.ThreeSum(testData);

            Assert.Equal([[0, 0, 0]], result);
        }

        [Fact]
        public void Test4()
        {
            int[] testData = [0, 0, 0, 0];
            var rangeSum = new ThreeSumSolution();

            var result = rangeSum.ThreeSum(testData);

            Assert.Equal([[0, 0, 0]], result);
        }
    }
}