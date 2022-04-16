using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime _duration_start;
        private TimeSpan _duration;
        public Stopwatch()
        {
            _duration_start = new DateTime();
            _duration = new TimeSpan();
        }

        public void Start()
        {
            _duration_start = DateTime.Now;
        }

        public TimeSpan Stop()
        {
            _duration = DateTime.Now - _duration_start;
            return _duration;
        }

        public void ResetWatch()
        {
            if (_duration_start != default)
                _duration = default;
        }
    }
}
