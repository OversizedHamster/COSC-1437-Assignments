using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListDemonstrator;
using Shouldly;

namespace LinkedListDemonstrator_Tests
{
    [TestClass]
    public class NodeDemonstrator_Tests
    {
        class SimpleNodeUsedForTesting
        {
            public string Name;
            public int ANumber;
        }

        [TestMethod]
        public void Verify_LinkedListNode_Basic_Behavior()
        {
            // Assign

            var myTestNode = new SimpleNodeUsedForTesting()
            {
                Name = "Prof Reynolds",
                ANumber = 42
            };

            // Act
            var linkedListNode = new NodeDemonstrator<SimpleNodeUsedForTesting>()
            {
                Value = myTestNode
            };

            // Assert
            linkedListNode.Value.Name.ShouldBe("Prof Reynolds");
            linkedListNode.Value.ANumber.ShouldBe(42);
        }

        [TestMethod]
        public void Verify_LinkedListNode_Links()
        {
            // Assign

            var myTestNode1 = new SimpleNodeUsedForTesting()
            {
                Name = "Prof Reynolds",
                ANumber = 1
            };
            var myTestNode2 = new SimpleNodeUsedForTesting()
            {
                Name = "a Student",
                ANumber = 2
            };
            var myTestNode3 = new SimpleNodeUsedForTesting()
            {
                Name = "an other Student",
                ANumber = 3
            };

            
            // Act
            var linkedListNode1 = new NodeDemonstrator<SimpleNodeUsedForTesting>()
            {
                Value = myTestNode1
            };

            var linkedListNode2 = new NodeDemonstrator<SimpleNodeUsedForTesting>()
            {
                Value = myTestNode2
            };
            linkedListNode1.Next = linkedListNode2;
            linkedListNode2.Previous= linkedListNode1;

            var linkedListNode3 = new NodeDemonstrator<SimpleNodeUsedForTesting>()
            {
                Value = myTestNode3
            };
            linkedListNode2.Next = linkedListNode3;
            linkedListNode3.Previous = linkedListNode2;


            // Assert
            linkedListNode1.Value.ANumber.ShouldBe(1);
            linkedListNode1.Next.ShouldBe(linkedListNode2);
            linkedListNode1.Next.Previous.ShouldBe(linkedListNode1);
            linkedListNode1.Previous.ShouldBeNull();

            linkedListNode2.Value.ANumber.ShouldBe(2);
            linkedListNode2.Previous.ShouldBe(linkedListNode1);
            linkedListNode2.Next.ShouldBe(linkedListNode3);
            linkedListNode2.Previous.Next.ShouldBe(linkedListNode2);
            linkedListNode2.Next.Previous.ShouldBe(linkedListNode2);

            linkedListNode3.Value.ANumber.ShouldBe(3);
            linkedListNode3.Previous.ShouldBe(linkedListNode2);
            linkedListNode3.Previous.Next.ShouldBe(linkedListNode3);
            linkedListNode3.Next.ShouldBeNull();

        }
    }
}
