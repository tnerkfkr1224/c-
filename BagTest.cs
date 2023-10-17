using System;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using SwinAdventure;

namespace UnitTest
{
    [TestFixture]
    public class BagTest
    {
        private Item item;
        private Bag bag;

        [SetUp]
        public void Setup()
        {
            item = new Item(new String[] { "shovel", "spade" }, "a shovel",
                       "This is a might fine ...");
            bag = new Bag(new String[] { "Grape", "Potato" }, "a Grape",
                       "This is a might good ...");
        }
       
        [Test]
        public void TestBagLocatesItems()
        {
            bag.Inventory.Put(item);
            Assert.AreEqual(bag.Locate("shovel"),item);

        }
       
        
        [Test]
        public void TestBagLocatesitself()
        {        
            Assert.AreEqual(bag.Locate("Grape"),bag);
        }
       
        [Test]
        public void TestBagLocatenothing()
        {
            Assert.AreEqual(bag.Locate("yy"),null);
        }
      
        [Test]
        public void TestBaginBag()
        {
            //Create two Bag objects(b1, b2)
            Bag b1 = new Bag(new String[] { "bag1", "test" }, "a bag1",
                       "This is a might look ...");
            Bag b2 = new Bag(new String[] { "bag2", "test2" }, "a bag2",
                       "This is a might see ...");
            Item item = new Item(new String[] { "shovel", "spade" }, "a shovel",
                       "This is a might fine ...");
            Item item2 = new Item(new String[] { "shovel2", "spade2" }, "a shovel2",
                       "This is a might okay ...");

            //put b2 in b1 inventory.
            b1.Inventory.Put(b2);
            b1.Inventory.Put(item);

            //Test that b1 can locate b2
            Assert.AreEqual(b1.Locate("bag2"),b2);


            //Test that b1 can locate other items in b1
            Assert.AreEqual(b1.Locate("shovel"),item);


            b2.Inventory.Put(item2);
            //Test that b1 can not locate items in b2.
            Assert.AreEqual(b1.Locate("shovel2"),null);

        }

        [Test()]
        public void TestBagFullDesc()
        {
            bag.Inventory.Put(item);
            Assert.AreEqual(bag.FullDescription, "In the" + bag.Name + "You can see" + item.ShortDescription + "\n\t");
        }

    }
}

        
