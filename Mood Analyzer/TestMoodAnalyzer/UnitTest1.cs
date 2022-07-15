using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzer;
namespace MoodAnalyzer
{
    [TestClass]
    public class UnitTest1
    {
        //Arrangement
        MoodAnalyzer moodAnalyzer = new MoodAnalyzer();

        [TestMethod]
        public void CheckMoodHappy()
        {
            //Action

            string res = moodAnalyzer.CheckMood("Vinay  is Happy for his new Bike");

            //Assert

            Assert.AreEqual("happy", res);
        }
        [TestMethod]
        public void CheckMoodSad()
        {
            //Action

            string res = moodAnalyzer.CheckMood("Akash is Sad after getting  fail in exam");

            //Assert

            Assert.AreEqual("sad", res);
        }
    }
}
