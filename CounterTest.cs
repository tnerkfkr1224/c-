using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using NUnit.Framework;
using Program;

namespace ClockTest
{
    [TestFixture]
    public class CounterTest
    {
        private Counter _counter;

        [SetUp]
        public void SetUp()
        {
            _counter = new Counter("test");
        }

        [Test]
        public void Initialize()
        {
            int count = 0;
            Assert.AreEqual(0, count);
        }

        [Test]
        public void Incrementing()
        {
            _counter.Increment();
            int count = _counter.Ticks;
            Assert.AreEqual(1, count);
        }


        [Test]
        public void MultipleIncrementing()
        {
            _counter.Increment();
            _counter.Increment();
            _counter.Increment();
            int count = _counter.Ticks;
            Assert.AreEqual(3, count);
        }

        [Test]
        public void Reserting()
        {
            _counter.Increment();
            _counter.Reset();
            int count = _counter.Ticks;
            Assert.AreEqual(0, count);
        }
    }
}