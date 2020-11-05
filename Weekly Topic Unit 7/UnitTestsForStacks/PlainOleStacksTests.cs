using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

/*
 * ProfReynolds
 */

namespace UnitTestsForStacks
{
    [TestClass]
    public class PlainOleStacksTests
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
            myStack.Push(123);
            myStack.Push("ProfReynolds");
            myStack.Push(new Object());
            myStack.Push("COSC-1437");
            myStack.Push(3.14);

            // assert
            myStack.Count.ShouldBe(5);
            
            var scratch1 = myStack.Peek();
            scratch1.ShouldBe(3.14);

            var scratch2 = myStack.Pop();
            scratch2.ShouldBe(3.14);
            
            var scratch3 = myStack.Pop();
            scratch3.ShouldBe("COSC-1437");
            
            myStack.Pop();
            myStack.Pop();
            
            myStack.Count.ShouldBe(1);
            
            var scratch4 = myStack.Pop();
            scratch4.ShouldBe(123);

            myStack.Count.ShouldBe(0);
        }

        [TestMethod]
        public void ReturnAnArray()
        {
            // assign
            var myStack = new Stack();

            // act
            myStack.Push(123);
            myStack.Push("ProfReynolds");
            myStack.Push(new Object());
            myStack.Push("COSC-1437");
            myStack.Push(3.14);

            // assert
            myStack.Count.ShouldBe(5);
            
            var myStackArray = myStack.ToArray();
            myStackArray.ShouldBeOfType<object[]>();
            myStackArray[0].ShouldBe(3.14);
            myStackArray[1].ShouldBe("COSC-1437");
            myStackArray[2].ShouldBeOfType<object>();
            myStackArray[3].ShouldBe("ProfReynolds");
            myStackArray[4].ShouldBe(123);
        }

    }
}
