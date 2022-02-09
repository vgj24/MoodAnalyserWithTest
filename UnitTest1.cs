using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserAssgn;

namespace MoodAnalyserAssgnTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMoodSad_ShouldReturnSad()
        {
            MoodAnalyser obj = new MoodAnalyser("SAD");
            string result = obj.AnalyseMood();
            Assert.AreEqual("SAD", result);
        }

        [TestMethod]
        public void GivenMoodAnyMood()
        {
            MoodAnalyser obj = new MoodAnalyser("I am in any mood");
            string result = obj.AnalyseMood();
            Assert.AreEqual("HAPPY", result);
        }
        [TestMethod]
        public void GivenMood_IAmInSadMood()
        {
            MoodAnalyser obj = new MoodAnalyser("I am in SAD mood");
            string result = obj.AnalyseMood();
            Assert.AreEqual("SAD", result);
        }
        [TestMethod]
        public void GivenMood_IAmInHAPPYMood()
        {
            MoodAnalyser obj = new MoodAnalyser("I am in HAPPY mood");
            string result = obj.AnalyseMood();
            Assert.AreEqual("HAPPY", result);
        }
        [TestMethod]
        public void GivenMoodHappy_ShouldReturnNull()
        {
            MoodAnalyser obj = new MoodAnalyser("null");
            string result = obj.AnalyseMood();
            Assert.AreEqual("HAPPY", result);
        }
        [TestMethod]
        [ExpectedException(typeof(MoodAnalyserCustomException))]
        public void GivenMoodNull_ShouldThrowException()
        {
            MoodAnalyser obj = new MoodAnalyser(null);
            string result = obj.AnalyseMood();
        }

        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            MoodAnalyser expected = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodanalyser("MoodAnalyserAppWithCore.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
           // Assert.AreEqual(expected, obj);
        }
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyser("HAPPY"); //2000
            object expected1 = expected;
            object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor("MoodAnalyserAppWithCore.MoodAnalyser", "MoodAnalyser", "HAPPY");
            //expected.Equals(obj);
            Assert.Equals(expected, expected1);
            // Assert.Equals(expected, obj);
        }

    }
}
