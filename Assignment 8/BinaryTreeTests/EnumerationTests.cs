using System.Linq;
using BinaryTreeImplementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

/*
 * ProfReynolds & Ethan Smith
 */

namespace BinaryTreeTests
{
    [TestClass]
    public class EnumerationTests
    {
        [TestMethod]
        public void Enumerator_Of_Single()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            foreach (int item in tree)
            {
                Assert.Fail("An empty tree should not enumerate any values");
            }

            tree.Contains(10).ShouldBeFalse("Tree should not contain 10 yet");

            tree.Add(10);

            tree.Contains(10).ShouldBeTrue("Tree should contain 10");

            int count = 0;
            foreach (int item in tree)
            {
                count++;
                count.ShouldBe(1, "The item value should be 10");
                10.ShouldBe(item, "There should be exactly one item");
            }
        }

        [TestMethod]
        public void InOrder_Enumerator()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            //        8
            //       / \
            //      6   1
            //     / \   \
            //    5   7   3
            //           / \
            //          2   4

            tree.Add(8);
            tree.Add(1);
            tree.Add(6);
            tree.Add(3);
            tree.Add(7);
            tree.Add(2);
            tree.Add(5);
            tree.Add(4);

            int[] expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            int index = 0;

            foreach (int actual in tree)
            {
                actual.ShouldBe(expected[index++], "The item enumerated in the wrong order");
            }
        }


        [TestMethod]
        public void InOrder_Delegate()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            //        4
            //       / \
            //      2   5
            //     / \   \
            //    1   3   7
            //           / \
            //          6   8

            tree.Add(4);
            tree.Add(5);
            tree.Add(2);
            tree.Add(7);
            tree.Add(3);
            tree.Add(6);
            tree.Add(1);
            tree.Add(8);

            int[] expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            int index = 0;

            tree.InOrderTraversal(item => 
                item.ShouldBe(expected[index++], "The item enumerated in the wrong order"));
        }

        [TestMethod]
        public void PreOrder_Delegate()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            //        4
            //       / \
            //      2   5
            //     / \   \
            //    1   3   7
            //           / \
            //          6   8

            tree.Add(4);
            tree.Add(5);
            tree.Add(2);
            tree.Add(7);
            tree.Add(3);
            tree.Add(6);
            tree.Add(1);
            tree.Add(8);

            int[] expected = new[] { 4, 2, 1, 3, 5, 7, 6, 8 };

            int index = 0;

            tree.PreOrderTraversal(item => 
                item.ShouldBe(expected[index++], "The item enumerated in the wrong order"));
        }

        [TestMethod]
        public void PostOrder_Delegate()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            //        4
            //       / \
            //      2   5
            //     / \   \
            //    1   3   7
            //           / \
            //          6   8

            tree.Add(4);
            tree.Add(5);
            tree.Add(2);
            tree.Add(7);
            tree.Add(3);
            tree.Add(6);
            tree.Add(1);
            tree.Add(8);

            int[] expected = new[] { 1, 3, 2, 6, 8, 7, 5, 4 };

            int index = 0;

            tree.PostOrderTraversal(item => 
                item.ShouldBe(expected[index++], "The item enumerated in the wrong order"));
        }

        [TestMethod]
        public void Enumerator_Of_Double()
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            foreach (int item in tree)
            {
                Assert.Fail("An empty tree should not enumerate any values");
            }

            tree.Contains(5).ShouldBeFalse("Tree should not contain 5 yet");
            tree.Contains(15).ShouldBeFalse("Tree should not contain 15 yet");

            tree.Add(5);
            tree.Add(15);

            tree.Contains(5).ShouldBeTrue("Tree should contain 5");
            tree.Contains(15).ShouldBeTrue("Tree should contain 15");
        }

        [TestMethod]
        public void Another_Test_Sortation()
        {
            BinaryTree<int> tree = new BinaryTree<int>(); 
            int[] values2Start = new[] { 4, 2, 1, 3, 8, 6, 7, 5 };
            foreach (int i in values2Start)
            {
                tree.Add(i);
            }     
            var expectedResult = values2Start.OrderBy(item => item).ToArray();

            foreach (int v in values2Start)
            {
                expectedResult.Contains(v).ShouldBeTrue();
            }
        }
    }
}
