using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

//Ethan Smith

namespace MyTestsForQueues
{
    [TestClass]
    public class PlainOleQueuesTests
    {
        [TestMethod]
        public void Create_Queue_And_Verify_Empty()
        {
            // assign
            var myQueue = new Queue();

            // act

            // assert
            myQueue.Count.ShouldBe(0);

            Should.Throw<InvalidOperationException>(
                () => myQueue.Dequeue()
                );

            Should.Throw<InvalidOperationException>(
                () => myQueue.Peek()
            );
        }

        [TestMethod]
        public void Queue_And_Dequeue_Values()
        {
            // assign
            var myQueue = new Queue();

            // act
            myQueue.Enqueue(123);
            myQueue.Enqueue("ProfReynolds");
            myQueue.Enqueue(new Object());
            myQueue.Enqueue("COSC-1437");
            myQueue.Enqueue(3.14);

            // assert
            myQueue.Count.ShouldBe(5);

            var scratch1 = myQueue.Peek();
            scratch1.ShouldBe(123);

            var scratch2 = myQueue.Dequeue();
            scratch2.ShouldBe(123);

            var scratch3 = myQueue.Dequeue();
            scratch3.ShouldBe("ProfReynolds");

            myQueue.Dequeue();
            myQueue.Dequeue();

            myQueue.Count.ShouldBe(1);

            var scratch4 = myQueue.Dequeue();
            scratch4.ShouldBe(3.14d);

            myQueue.Count.ShouldBe(0);
        }

        [TestMethod]
        public void ReturnAnArray()
        {
            // assign
            var myQueue = new Queue();

            // act
            myQueue.Enqueue(123);
            myQueue.Enqueue("ProfReynolds");
            myQueue.Enqueue(new Object());
            myQueue.Enqueue("COSC-1437");
            myQueue.Enqueue(3.14);

            // assert
            myQueue.Count.ShouldBe(5);

            var myQueueArray = myQueue.ToArray();
            myQueueArray.ShouldBeOfType<object[]>();
            myQueueArray[0].ShouldBe(123);
            myQueueArray[1].ShouldBe("ProfReynolds");
            myQueueArray[2].ShouldBeOfType<object>();
            myQueueArray[3].ShouldBe("COSC-1437");
            myQueueArray[4].ShouldBe(3.14);
        }
    }
}
