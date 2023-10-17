using System;
using Program;

namespace CounterTest
{
    [TestFixture]
    public class ClockTest
    {

        private Clock _clock;
        //private Counter _counter;

        [SetUp]
        public void SetUp()
        {
            _clock = new Clock();
        }

        [TestCase("00:00:00")]
        public void TestDefualt(string testTure)
        {
            Assert.IsTrue(_clock.Read== "00:00:00");
        }

        //1 minutes
        [TestCase("00:01:00")]
        public void TestTickS(string testTure)
        {
          for(int i =0;i<60; i++)
            {
                _clock.Tick();
            }
            Assert.IsTrue(_clock.Read == testTure);
        }

        //1 hours
        [TestCase("01:00:00")]
        public void TestTickM(string testTure)
        {
            for (int i = 0; i < 3600; i++)
            {
                _clock.Tick();
            }
            Assert.IsTrue(_clock.Read == testTure);
        }

        //1 days=24
        [TestCase("00:00:00")]
        public void TestTickH(string testTure)
        {
            for (int i = 0; i < 86400; i++)
            {
                _clock.Tick();
            }
            Assert.IsTrue(_clock.Read == testTure);
        }

        [TestCase("00:00:00")]
        public void TestResetAll(string testTure)
        {
            for (int i = 0; i < 100; i++)
            {
                _clock.Tick();
            }
            _clock.ResetAll();
            Assert.IsTrue(_clock.Read == testTure);
        }
    }       
}