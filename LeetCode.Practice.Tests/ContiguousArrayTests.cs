namespace LeetCode.Practice.Tests
{
    public class ContiguousArrayTests
    {
        [Fact]
        public void Test1()
        {
            var contiguousArray = new ContiguousArray();

            var result = contiguousArray.FindMaxLength([0, 1]);

            Assert.Equal(2, result);
        }


        [Fact]
        public void Test2()
        {
            var contiguousArray = new ContiguousArray();

            var result = contiguousArray.FindMaxLength([0, 1, 1, 1, 1, 1, 0, 0, 0]);

            // [1,1,1,0,0,0]
            Assert.Equal(6, result);
        }

        [Fact]
        public void Test3()
        {
            var contiguousArray = new ContiguousArray();

            //'0, 1, 1, 0, 0  ,1 ,0, 1, 1, 0,'
            var result = contiguousArray.FindMaxLength([0, 1, 1,0,0, 1,0, 1, 1, 0, 0, 0]);

            Assert.Equal(10, result);
        }


        [Fact]
        public void Test5()
        {
            var contiguousArray = new ContiguousArray();

            var result = contiguousArray.FindMaxLength([0, 1, 0]);

            Assert.Equal(2, result);
        }
    }
}