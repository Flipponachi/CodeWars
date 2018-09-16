using NUnit.Framework;

namespace CodeWars.CodeWarsTests
{
  
    [TestFixture]
    public class CodeKatasTests
    {
        private CodeKatas _codeKatas;

        [SetUp]
        public void Setup()
        {
            _codeKatas = new CodeKatas();
        }
        [Test]
        [TestCase("aabaa", true)]
        [TestCase("abac", false)]
        [TestCase("a", true)]
        [TestCase("z", true)]
        [TestCase("zzzazzazz", false)]
        public void IsPalindrome_DifferentValue_ReturnsCorrectValue(string value, bool expectedResult)
        {
           
            var result = _codeKatas.IsPalindrome(value);
            
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(16, 7)]
        [TestCase(942, 6)]
        [TestCase(132189, 6)]
        public void DigitalRoot_InputValue_ReturnsFirstRecursiveValue(int value, int expectedValue)
        {
            var result = _codeKatas.DigitalRoot(value);
            Assert.That(result, Is.EqualTo(expectedValue));
        }
        
    }
}