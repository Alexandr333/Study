using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Practise;

namespace TTD_Practise.Tests
{
    [TestClass]
    public class TDD_Practise_Test
    {
        [TestMethod]
        public void ShouldCompressOnlyLetters()
        {
            String_Easy_Compressor compressor = new String_Easy_Compressor();

            string compresedString = compressor.Compress("((aaabb111 ccccddd)(eeefggg hhkl))");
            string testSample = "((a3b2111 c4d3)(e3fg3 h2kl))";

            Assert.AreEqual<string>(compresedString, testSample);
        }
    }
}
