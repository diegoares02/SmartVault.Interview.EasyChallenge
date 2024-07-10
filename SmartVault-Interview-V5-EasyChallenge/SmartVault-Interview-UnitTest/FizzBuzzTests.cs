using TwistedFizzBuzz;
namespace SmartVault_Interview_UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestStandarFizzBuzz()
        {
            int number = 10;
            string expected = "12Fizz4BuzzFizz78Fizz";
            string actualResult = FizzBuzz.StandarFizzBuzz(number).Replace("\r\n", "");
            Assert.AreEqual(expected, actualResult);
        }
        [Test]
        public void TestTwistedFizzBuzz()
        {
            Dictionary<int, string> tokenNumbers = new Dictionary<int, string>();
            tokenNumbers.Add(3, "Fizz");
            tokenNumbers.Add(5, "Buzz");
            string expected = "Buzz-19Fizz-17-16FizzBuzz-14-13Fizz-11BuzzFizz-8-7FizzBuzz-4Fizz-2-1FizzBuzz";
            string actualResult = FizzBuzz.TFizzBuzz(tokenNumbers, "-20 - 1").Replace("\r\n", "");
            Assert.AreEqual(expected, actualResult);
        }

        [Test]
        public void TestTwistedFizzBuzzNoSequence()
        {
            Dictionary<int, string> tokenNumbers = new Dictionary<int, string>();
            tokenNumbers.Add(7, "Poem");
            tokenNumbers.Add(17, "Write");
            tokenNumbers.Add(3, "College");
            string expected = "PoemWriteWriteCollegePoemCollegePoemWriteCollege";
            string actualResult = FizzBuzz.TFizzBuzz(tokenNumbers, "119,51,21,357").Replace("\r\n", "");
            Assert.AreEqual(expected, actualResult);
        }
    }
}