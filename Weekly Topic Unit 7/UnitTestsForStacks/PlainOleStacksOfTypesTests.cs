using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

//Ethan Smith

namespace UnitTestsForStacks
{
    [TestClass]
    public class PlainOleStacksOfTypesTests
    {
        [TestMethod]
        public void Create_Stack_And_Verify_Empty()
        {
            // assign
            var myStack = new Stack();

            // act

            // assert
            myStack.Count.ShouldBe(0);

            Should.Throw<InvalidOperationException>(
                () => myStack.Pop()
                );

            Should.Throw<InvalidOperationException>(
                () => myStack.Peek()
            );
        }

        [TestMethod]
        public void Push_And_Pop_Values()
        {
            // assign
            var myStack = new Stack();

            // act
            myStack.Push(111);
            myStack.Push(222);
            myStack.Push(333);
            myStack.Push(444);
            myStack.Push(555);

            // assert
            myStack.Count.ShouldBe(5);

            var scratch1 = myStack.Peek();
            scratch1.ShouldBe(555);

            var scratch2 = myStack.Pop();
            scratch2.ShouldBe(555);

            var scratch3 = myStack.Pop();
            scratch3.ShouldBe(444);

            myStack.Pop();
            myStack.Pop();

            myStack.Count.ShouldBe(1);

            var scratch4 = myStack.Pop();
            scratch4.ShouldBe(111);

            myStack.Count.ShouldBe(0);
        }

        [TestMethod]
        public void ReturnAnArray()
        {
            // assign
            var myStack = new Stack();

            // act
            myStack.Push(111);
            myStack.Push(222);
            myStack.Push(333);
            myStack.Push(444);
            myStack.Push(555);

            // assert
            myStack.Count.ShouldBe(5);

            var myStackArray = myStack.ToArray();
            myStackArray.ShouldBeOfType<object[]>();
            myStackArray[0].ShouldBe(555);
            myStackArray[1].ShouldBe(444);
            myStackArray[2].ShouldBe(333);
            myStackArray[3].ShouldBe(222);
            myStackArray[4].ShouldBe(111);
        }
    }
}
