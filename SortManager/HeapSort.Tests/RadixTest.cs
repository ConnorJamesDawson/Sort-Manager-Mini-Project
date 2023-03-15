using SortManager.App;
namespace MaxRadix
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int[] pass = new int[] { 0, 1, 1, 2, 2,3,3,6,9, 2, 4, 5,6,8, 5, 5, 7};
            var test = SortManager.App.Model.MaxRadix.Radix(pass);
            Assert.That(test, Is.EqualTo("0,1,1,2,2,2,3,3,4,5,5,5,6,6,7,8,9,"));
        }
    }
}