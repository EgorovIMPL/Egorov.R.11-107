using NUnit.Framework;
using Egorov.R._11_107.ControlWork_21._03._2022;
namespace TestProject1
{
    [TestFixture]
    public class CollectionTest
    {
        [Test]
        public void TestAdding()
        {
            CustomQueue<int> queue = new CustomQueue<int>(1);
            queue.Add(2);
            Assert.AreEqual(queue.ToString(), "1 2");
        }

        [Test]
        public void TestDeleting()
        {
            CustomQueue<int> queue = new CustomQueue<int>(1);
            queue.Add(2);
            queue.Add(3);
            queue.Delete();
            Assert.AreEqual(queue.ToString(), "2 3");
        }

        [Test]
        public void TestIsEmpty()
        {
            CustomQueue<int> queue = new CustomQueue<int>();
            Assert.True(queue.IsEmpty());
        }
        [Test]
        public void TestSize()
        {
            CustomQueue<int> queue = new CustomQueue<int>(1);
            queue.Add(2);
            queue.Add(3);
            Assert.AreEqual(queue.Size(), 3);
        }
        [Test]
        public void TestDelSecond()
        {
            CustomQueue<int> queue = new CustomQueue<int>(1);
            queue.Add(2);
            queue.Add(3);
            queue.DelSecond();
            Assert.AreEqual(queue.ToString(), "1 3");
        }
        [Test]
        public void TestDelPenultEl()
        {
            CustomQueue<int> queue = new CustomQueue<int>(1);
            queue.Add(2);
            queue.Add(3);
            queue.DelPenultEl();
            Assert.AreEqual(queue.ToString(), "1 3");
        }
    }
}