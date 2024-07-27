using Assignment_3_skeleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
/*using static System.Runtime.InteropServices.JavaScript.JSType;*/

namespace Test_Assignment_3
{
    public class LinkedListTests
    {
        private LinkedListADT linkedList;

        [SetUp]
        public void Setup()
        {
            // Create your concrete linked list class and assign to to linkedList.
            this.linkedList = new SLL();
        }

        [TearDown]
        public void TearDown()
        {
            this.linkedList.Clear();
        }

        //Test the linked list is empty.
        [Test]
        public void TestIsEmpty()
        {
            Assert.True(this.linkedList.IsEmpty());
            Assert.AreEqual(0, this.linkedList.Size());
        }

        //Tests appending elements to the linked list.
        [Test]
        public void TestAppendNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            /**
             * Linked list should now be:
             * 
             * a -> b -> c -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.AreEqual(4, this.linkedList.Size());

            // Test the first node value is a
            Assert.AreEqual("a", this.linkedList.Retrieve(0));

            // Test the second node value is b
            Assert.AreEqual("b", this.linkedList.Retrieve(1));

            // Test the third node value is c
            Assert.AreEqual("c", this.linkedList.Retrieve(2));

            // Test the fourth node value is d
            Assert.AreEqual("d", this.linkedList.Retrieve(3));
        }

        //Tests prepending nodes to linked list.
        [Test]
        public void testPrependNodes()
        {
            this.linkedList.Prepend("a");
            this.linkedList.Prepend("b");
            this.linkedList.Prepend("c");
            this.linkedList.Prepend("d");

            /**
             * Linked list should now be:
             * 
             * d -> c -> b -> a
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.AreEqual(4, this.linkedList.Size());

            // Test the first node value is a
            Assert.AreEqual("d", this.linkedList.Retrieve(0));

            // Test the second node value is b
            Assert.AreEqual("c", this.linkedList.Retrieve(1));

            // Test the third node value is c
            Assert.AreEqual("b", this.linkedList.Retrieve(2));

            // Test the fourth node value is d
            Assert.AreEqual("a", this.linkedList.Retrieve(3));
        }

        //Tests inserting node at valid index.
        [Test]
        public void TestInsertNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            this.linkedList.Insert("e", 2);

            /**
             * Linked list should now be:
             * 
             * a -> b -> e -> c -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.AreEqual(5, this.linkedList.Size());

            // Test the first node value is a
            Assert.AreEqual("a", this.linkedList.Retrieve(0));

            // Test the second node value is b
            Assert.AreEqual("b", this.linkedList.Retrieve(1));

            // Test the third node value is e
            Assert.AreEqual("e", this.linkedList.Retrieve(2));

            // Test the third node value is c
            Assert.AreEqual("c", this.linkedList.Retrieve(3));

            // Test the fourth node value is d
            Assert.AreEqual("d", this.linkedList.Retrieve(4));
        }

        //Tests replacing existing nodes data.
        [Test]
        public void TestReplaceNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            this.linkedList.Replace("e", 2);

            /**
             * Linked list should now be:
             * 
             * a -> b -> e -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.AreEqual(4, this.linkedList.Size());

            // Test the first node value is a
            Assert.AreEqual("a", this.linkedList.Retrieve(0));

            // Test the second node value is b
            Assert.AreEqual("b", this.linkedList.Retrieve(1));

            // Test the third node value is e
            Assert.AreEqual("e", this.linkedList.Retrieve(2));

            // Test the fourth node value is d
            Assert.AreEqual("d", this.linkedList.Retrieve(3));
        }

        //Tests deleting node from linked list.
        [Test]
        public void TestDeleteNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            this.linkedList.Delete(2);

            /**
             * Linked list should now be:
             * 
             * a -> b -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.AreEqual(3, this.linkedList.Size());

            // Test the first node value is a
            Assert.AreEqual("a", this.linkedList.Retrieve(0));

            // Test the second node value is b
            Assert.AreEqual("b", this.linkedList.Retrieve(1));

            // Test the fourth node value is d
            Assert.AreEqual("d", this.linkedList.Retrieve(2));
        }

        //Tests finding and retrieving node in linked list.
        [Test]
        public void TestFindNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            /**
             * Linked list should now be:
             * 
             * a -> b -> c -> d
             */

            bool contains = this.linkedList.Contains("b");
            Assert.True(contains);

            int index = this.linkedList.IndexOf("b");
            Assert.AreEqual(1, index);

            string value = (string)this.linkedList.Retrieve(1);
            Assert.AreEqual("b", value);
        }

        //test node creation and equality
        [Test]
        public void TestGetNode()
        {
            Node a = new Node("a");
            Node b = new Node("b");
            Node c = new Node("c");

            this.linkedList.Append(a);
            this.linkedList.Append(b);
            this.linkedList.Append(c);

            Assert.IsFalse(this.linkedList.IsEmpty());
            Assert.AreEqual(a, this.linkedList.Retrieve(0));
            Assert.AreEqual(b, this.linkedList.Retrieve(1));
            Assert.AreEqual(c, this.linkedList.Retrieve(2));
        }

        //test that clearing an already empty list doesn't change anything
        [Test]
        public void TestClearEmptyList()
        {
            this.linkedList.Clear();
            Assert.IsTrue(this.linkedList.IsEmpty());

            this.linkedList.Clear();
            Assert.IsFalse(!this.linkedList.IsEmpty());
        }

        [Test]
        public void TestNodeValuesSame()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("a");

            Assert.IsTrue(this.linkedList.Retrieve(0) == this.linkedList.Retrieve(2));
            Assert.IsFalse(this.linkedList.Retrieve(0) == this.linkedList.Retrieve(1));
        }

        [Test]
        public void TestRetrieveException()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            Assert.Throws<IndexOutOfRangeException>(() => linkedList.Retrieve(3));
        }

        [Test]
        public void TestReplaceException()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            Assert.Throws<IndexOutOfRangeException>(() => linkedList.Replace("n", 3));
        }

        [Test]
        public void TestDeleteException()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            Assert.Throws<IndexOutOfRangeException>(() => linkedList.Delete(5));
        }
    }
}
