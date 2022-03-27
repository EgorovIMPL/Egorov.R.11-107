using Egorov.R._11_107;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class SakhirTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(new Sakhir().Run(new int[,]{{0,0,1,0},{0,1,0,0}}),5);
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(new Sakhir().Run(new int[,]{{0,0,0,0,1,0},{0,0,0,0,1,0},{0,0,1,0,0,0}}),12);
        }
        
        [Test]
        public void Test3()
        {
            Assert.AreEqual(new Sakhir().Run(new int[,]{{0,1,1,1,0},{0,1,1,1,0},{0,1,1,1,0},{0,1,1,1,0}}),18);
        }
    }
}