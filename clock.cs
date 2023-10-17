using System;
namespace Program
{
        public class Clock
        {
            private Counter hours;
            private Counter minutes;
            private Counter seconds;

        public Clock()
        {
            hours = new Counter("hours");
            minutes = new Counter("minutes");
            seconds = new Counter("seconds");
        }

        public void ResetAll()
        {
            hours.Reset();
            minutes.Reset();
            seconds.Reset();
        }

        public void Tick()
        {
            seconds.Increment();
            if(seconds.Ticks==60)
            {
                seconds.Reset();
                minutes.Increment();
            }
            if(minutes.Ticks==60)
            {
                minutes.Reset();
                hours.Increment();
            }
            if (hours.Ticks == 24)
            {
                ResetAll();
            }
        }

        public string Read
        {
            get
            {
                return hours.Ticks.ToString("00") + ":" + minutes.Ticks.ToString("00") + ":" + seconds.Ticks.ToString("00");
            }
        }
    }
}
