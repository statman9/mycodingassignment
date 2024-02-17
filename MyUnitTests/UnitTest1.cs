using MyProgram;

namespace MyApp.Tests
{
    [TestFixture]
    public class CheckStringTest
    {
        // Use parameterized test cases
        [Test]
        [TestCase("<>", true)]
        [TestCase("><", false)]
        [TestCase("<<>", false)]
        [TestCase("<>>", false)]
        [TestCase("“”", true)]
        [TestCase("<abcdefghijklmnopqrstuvwxyz>", true)]
        [TestCase("<This is another test>", true)]
        public void MyTest(string testString, bool expected)
        {
            // initialize actual class
            CheckString checkClass = new CheckString(testString);
            bool actual = checkClass.IsValidString();

            // Assert that the string validation is what we expected
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(actual, expected);
        }
    }
}
