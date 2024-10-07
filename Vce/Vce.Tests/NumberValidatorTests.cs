namespace Vce.Tests
{
    public class NumberValidatorTests
    {
        [Theory]
        [InlineData(null, true)] // Test for null
        [InlineData((short)0, true)]    // Test for zero
        [InlineData((short)5, false)]   // Test for positive short
        public void Test_IsNullOrZero_Short(short? value, bool expected)
        {
            Assert.Equal(expected, value.IsNullOrZero());
        }

        [Theory]
        [InlineData(null, true)] // Test for null
        [InlineData(0, true)]    // Test for zero
        [InlineData(10, false)]  // Test for positive int
        public void Test_IsNullOrZero_Int(int? value, bool expected)
        {
            Assert.Equal(expected, value.IsNullOrZero());
        }

        [Theory]
        [InlineData(null, true)] // Test for null
        [InlineData(0L, true)]    // Test for zero
        [InlineData(100L, false)] // Test for positive long
        public void Test_IsNullOrZero_Long(long? value, bool expected)
        {
            Assert.Equal(expected, value.IsNullOrZero());
        }

        //xUnit InlineData does not support decimal types directly. 

        [Theory]
        [InlineData(null, true)] // Test for null
        [InlineData(0f, true)]   // Test for zero
        [InlineData(3.14f, false)] // Test for positive float
        public void Test_IsNullOrZero_Float(float? value, bool expected)
        {
            Assert.Equal(expected, value.IsNullOrZero());
        }

        [Theory]
        [InlineData(null, true)] // Test for null
        [InlineData(0.0, true)]  // Test for zero
        [InlineData(2.718, false)] // Test for positive double
        public void Test_IsNullOrZero_Double(double? value, bool expected)
        {
            Assert.Equal(expected, value.IsNullOrZero());
        }
    }
}