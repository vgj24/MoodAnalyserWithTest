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
    }
}
