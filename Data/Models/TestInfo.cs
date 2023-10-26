using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class TestInfo
    {
        public int Repeat { get; private set; }
        public int FeedBackDelay { get; private set; }
        public int ShowTime { get; private set; }
        public int RepeatDelay { get; private set; }
        public int Frequency { get; private set; }
        public Type TestType { get; private set; }
        public bool IsAquzation { get; private set; }
        public TestInfo(int repeat, int feedbackdelay, int showtime, int repeatdelay, int frequency, Type type, bool isAquzation)
        {
            Repeat = repeat;
            FeedBackDelay = feedbackdelay * 1000;
            ShowTime = showtime * 1000;
            RepeatDelay = repeatdelay * 1000;
            Frequency = frequency;
            TestType = type;
            IsAquzation = isAquzation;
        }
    }
}
