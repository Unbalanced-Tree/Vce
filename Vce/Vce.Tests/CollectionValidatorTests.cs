using System.Collections.Generic;

namespace Vce.Tests
{
    public class CollectionValidatorTests
    {
        [Fact]
        public void Test_IsNullOrEmpty_Generic_List_1()
        {
            List<int> collection = null;
            Assert.True(collection.IsNullOrEmpty());
        }

        // Test for empty collection
        [Fact]
        public void Test_IsNullOrEmpty_Generic_List_2()
        {
            var emptyList =  new List<int>();
            Assert.True(emptyList.IsNullOrEmpty());
        }
        // Test for non-empty collection
        [Fact]
        public void Test_IsNullOrEmpty_Generic_List_3()
        {
            var collection = new List<int> { 1, 2, 3};
            Assert.False(collection.IsNullOrEmpty());
        }
    }
}
