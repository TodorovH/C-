using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem7LinkedQueueMain.Tests
{
    [TestClass]
    public class LinkedQueueUnitTests
    {
        [TestMethod]
        public void Enqueue_element_should_encrease_the_Count_and_Dequeue_should_decrease_the_Count_and_return_the_same_element()
        {
            var arr = new LinkedQueue<int>();

            arr.Enqueue(5);

            Assert.AreEqual(1, arr.Count);

            int element = arr.Dequeue();

            Assert.AreEqual(0, arr.Count);
            Assert.AreEqual(5, element);
        }

        [TestMethod]
        public void Enqueue_1000_elements_should_encrease_the_Count_and_Dequeue_them_should_decrease_the_Count_and_return_the_last_element()
        {
            var arr = new LinkedQueue<String>();
            String s = "";

            for (int i = 1000; i > 0; i--)
            {
                arr.Enqueue(String.Format("{0}", i));
            }


            Assert.AreEqual(1000, arr.Count);

            for (int i = 1000; i > 0; i--)
            {
                s = arr.Dequeue();
            }

            Assert.AreEqual(0, arr.Count);
            Assert.AreEqual("1", s);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Dequeue_from_empty_queue_should_throw_InvalidOperationException()
        {
            var arr = new LinkedQueue<int>();

            var element = arr.Dequeue();
        }

        [TestMethod]
        public void Enqueue_and_Dequeue_element_should_encrease_and_decrease_Count_and_return_correct_element()
        {
            var arr = new LinkedQueue<String>();
            var s = "";

            Assert.AreEqual(0, arr.Count);

            arr.Enqueue("Pesho");

            Assert.AreEqual(1, arr.Count);

            arr.Enqueue("Gosho");

            Assert.AreEqual(2, arr.Count);

            s = arr.Dequeue();

            Assert.AreEqual("Pesho", s);
            Assert.AreEqual(1, arr.Count);

            s = arr.Dequeue();

            Assert.AreEqual("Gosho", s);
            Assert.AreEqual(0, arr.Count);
        }

        [TestMethod]
        public void Convert_queue_to_array_should_return_new_array_of_the_elements()
        {
            var arr = new LinkedQueue<int>();

            arr.Enqueue(3);
            arr.Enqueue(5);
            arr.Enqueue(-2);
            arr.Enqueue(7);

            var result = arr.ToArray();

            var expectedArr = new int[] { 3, 5, -2, 7 };

            CollectionAssert.AreEqual(expectedArr, result);
        }

        [TestMethod]
        public void Empty_queue_to_array_should_create_an_empty_array()
        {
            var arr = new LinkedQueue<DateTime>();

            var result = arr.ToArray();

            Assert.AreEqual(0, result.Length);
        }
    }
}