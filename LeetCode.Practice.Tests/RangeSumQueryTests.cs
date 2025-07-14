namespace LeetCode.Practice.Tests
{
    public class RangeSumQueryTests
    {
        [Fact]
        public void Test1()
        {
            var rangeSum = new RangeSumQuery([1, 2, 3, 4, 5, 6]);

            var result = rangeSum.SumRange(1, 3);

            Assert.Equal(9, result);
        }

        [Fact]
        public void Test2()
        {
            var rangeSum = new RangeSumQuery([-2, 0, 3, -5, 2, -1]);

            var result = rangeSum.SumRange(0, 2);
            Assert.Equal(1, result);
            
            result = rangeSum.SumRange(2, 5);
            Assert.Equal(-1, result);

            result = rangeSum.SumRange(0, 5);
            Assert.Equal(-3, result);

            var wealthiest = new List<int>();

            //wealthiest.Count
        }
    }
}