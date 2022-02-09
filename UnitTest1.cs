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
            Assert.AreEqual("SAD",result);
        }

        [TestMethod]
        public void GivenMoodAnyMood()
        {
            MoodAnalyser obj = new MoodAnalyser("I am in any mood");
            string result = obj.AnalyseMood();
            Assert.AreEqual("HAPPY", result);
        }
    }
}
