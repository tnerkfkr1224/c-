using NUnit.Framework;
using SwinAdventure;
namespace NUnitTest
{
    public class LookCommandTest
    {

        private LookCommand cmd;
        private Player player;
        private Bag bag;
        private Item shovel;
        private Item gem;

        [SetUp]
        public void Setup()
        {

            cmd = new LookCommand();
            player = new Player("me", "inventory");
            bag = new Bag(new string[] { "bag" }, "bag_name", "this is a bag");
            shovel = new Item(new string[] { "shovel" }, "a shovel", "this is a shovel");
            gem = new Item(new string[] { "gem" }, "a gem", "this is a gem");
        }
  
        [Test]
        public void TestLookAtme()
        {
            player.Inventory.Put(shovel);
            Assert.AreEqual(cmd.Execute(player, new string[] { "look", "at", "inventory" }), player.FullDescription);
        }

        [Test]
        public void TestLookAtGem()
        {
            player.Inventory.Put(gem);
            Assert.AreEqual(cmd.Execute(player, new string[] { "look", "at", "gem" }), gem.FullDescription);
        }

        [Test]
        public void TestLookAtUnk()
        {
            Assert.AreEqual(cmd.Execute(player, new string[] { "look", "at", "gem" }), "i cannot find the gem");
        }

        [Test]
        public void TestLookAtGemInMe()
        {
            player.Inventory.Put(gem);
            Assert.AreEqual(cmd.Execute(player, new string[] { "look", "at", "gem" ,"in" ,"inventory" }), gem.FullDescription);
        }

        [Test]
        public void TestLookAtGemIntheBag()
        {
            bag.Inventory.Put(gem);
            player.Inventory.Put(bag);
            Assert.AreEqual(cmd.Execute(player, new string[] { "look", "at", "gem", "in", "bag" }),gem.FullDescription);
        }

        [Test]
        public void TestLookAtGemInNoBag()
        {
            Assert.AreEqual(cmd.Execute(player, new string[] { "look", "at", "gem", "in", "bag" }), "i cannot find the bag");
        }

        [Test]
        public void TestLookNoGemInBag()
        {
            player.Inventory.Put(bag);
            Assert.AreEqual(cmd.Execute(player, new string[] { "look", "at", "gem", "in", "bag" }), "i cannot find the gem");
        }

        [Test]
        public void TestInvalidLook()
        {
            Assert.AreEqual(cmd.Execute(player, new string[] { "look"}), "I don't know how to look like that");
            Assert.AreEqual(cmd.Execute(player, new string[] { "look","hello" }), "I don't know how to look like that");
            Assert.AreEqual(cmd.Execute(player, new string[] { "okk","hello","ths" }), "Error in look input");
            Assert.AreEqual(cmd.Execute(player, new string[] { "look", "hello","at"}), "What do you want to look at?");
            Assert.AreEqual(cmd.Execute(player, new string[] { "look", "at", "at","shovel","bag" }), "What do you want to look in?");
        }


    }
}

