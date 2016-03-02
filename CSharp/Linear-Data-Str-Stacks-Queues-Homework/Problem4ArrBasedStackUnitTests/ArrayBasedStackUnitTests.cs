using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Problem3ImplArrayBasedStack.Tests
{
    [TestClass]
    public class ArrayBasedStackUnitTests
    {
        [TestMethod]
        public void The_Constructor_should_create_new_stack_of_integers_with_Count_Equal_to_Zero()
        {
            var arr = new ArrayBasedStack<int>();

            Assert.AreEqual(0, arr.Count);
        }

        [TestMethod]
        public void Push_element_should_encrease_the_Count_and_Pop_should_decrease_the_Count_and_return_the_same_element()
        {
            var arr = new ArrayBasedStack<int>();

            arr.Push(5);

            Assert.AreEqual(1, arr.Count);

            int element = arr.Pop();

            Assert.AreEqual(0, arr.Count);
            Assert.AreEqual(5, element);
        }

        [TestMethod]
        public void The_Constructor_should_create_new_stack_of_strings_with_Count_Equal_to_Zero()
        {
            var arr = new ArrayBasedStack<String>();

            Assert.AreEqual(0, arr.Count);
        }

        [TestMethod]
        public void Push_1000_elements_should_encrease_the_Count_and_Pop_them_should_decrease_the_Count_and_return_the_same_element()
        {
            var arr = new ArrayBasedStack<String>();
            String s = "";

            for (int i = 1000; i > 0; i--)
            {
                arr.Push(String.Format("{0}", i));
            }
            

            Assert.AreEqual(1000, arr.Count);

            for (int i = 1000; i > 0; i--)
            {
                s = arr.Pop();
            }

            Assert.AreEqual(0, arr.Count);
            Assert.AreEqual("1000", s);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Pop_from_empty_stack_should_throw_InvalidOperationException()
        {
            var arr = new ArrayBasedStack<int>();

            var element = arr.Pop();
        }

        [TestMethod]
        public void Push_and_Pop_element_should_encrease_and_decrease_Count_and_return_correct_element()
        {
            var arr = new ArrayBasedStack<String>(1);
            var s = "";

            Assert.AreEqual(0, arr.Count);

            arr.Push("Pesho");

            Assert.AreEqual(1, arr.Count);

            arr.Push("Gosho");

            Assert.AreEqual(2, arr.Count);

            s = arr.Pop();

            Assert.AreEqual("Gosho", s);
            Assert.AreEqual(1, arr.Count);

            s = arr.Pop();

            Assert.AreEqual("Pesho", s);
            Assert.AreEqual(0, arr.Count);
        }

        [TestMethod]
        public void Convert_stack_to_array_should_return_elements_in_reversed_order()
        {
            var arr = new ArrayBasedStack<int>();

            arr.Push(3);
            arr.Push(5);
            arr.Push(-2);
            arr.Push(7);

            var result = arr.ToArray();

            var expectedArr = new int[] { 7, -2, 5, 3 };

            CollectionAssert.AreEqual(expectedArr, result);
        }

        [TestMethod]
        public void Empty_stack_to_array_should_create_an_empty_array()
        {
            var arr = new ArrayBasedStack<DateTime>();

            var result = arr.ToArray();

            Assert.AreEqual(0, result.Length);
        }
    }
}
