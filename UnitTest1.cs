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
    }
}
