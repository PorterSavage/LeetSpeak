using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;

namespace LeetSpeak.Tests
{
    [TestClass]
    public class LeetSpeakTest
    {
        [TestMethod]
        public void ReplaceWithThree_IfWordHasEThenReplaceWithThree()
        {
            Assert.AreEqual("3", LeetSpeakClass.Words("e"));    
        }

        [TestMethod]
        public void ReplaceWithZero_IfWordHasOThenReplaceWithZero()
        {
            Assert.AreEqual("0", LeetSpeakClass.Words("o"));
        }

        [TestMethod]
        public void ReplaceWithOne_IfWordHasCapitalIThenReplaceWithOne()
        {
            Assert.AreEqual("1", LeetSpeakClass.Words("I"));
        }

        [TestMethod]
        public void ReplaceWithSeven_IfWordHasTThenReplaceWithSeven()
        {
            Assert.AreEqual("7", LeetSpeakClass.Words("t"));
        }

        [TestMethod]
        public void ReplaceWithZ_IfWordHasSThenReplaceWithZ()
        {
            Assert.AreEqual("z", LeetSpeakClass.Words("s"));
        }
    }
}