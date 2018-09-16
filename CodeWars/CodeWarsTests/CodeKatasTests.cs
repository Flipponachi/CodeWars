using NUnit.Framework;

namespace CodeWars.CodeWarsTests
{
  
    [TestFixture]
    public class CodeKatasTests
    {
        [Test]
        [TestCase("aabaa", true)]
        [TestCase("abac", false)]
        [TestCase("a", true)]
        [TestCase("z", true)]
        [TestCase("zzzazzazz", false)]
        public void IsPalindrome_DifferentValue_ReturnsCorrectValue(string value, bool expectedResult)
        {
            var codeKatas = new CodeKatas();
            var result = codeKatas.IsPalindrome(value);
            
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        
    }
}