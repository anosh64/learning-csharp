using System;

namespace stopwatch
{
    public class Stopwatch
    {
        private DateTime? _startTime;
        private DateTime? _endTime;
        private bool _isRunning;

        public void Start()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("stopwatch is already running");
            }
            _startTime = DateTime.Now;
            _isRunning = true;
        }

        public void Stop()
        {
            if (!_isRunning)
            {
                throw new InvalidOperationException("stopwatch isn't running yet");
            }
            _endTime = DateTime.Now;
            _isRunning = false;
        }

        public TimeSpan Duration
        {
            get
            {
                if (_startTime == null || _endTime == null)
                {
                    throw new InvalidOperationException("stopwatch not started and stopped properly");
                }
                return _endTime.Value - _startTime.Value;
            }
        }



        public void Reset()
        {
            _startTime = null;
            _endTime = null;
            _isRunning = false;
        }
        public bool IsRunning => _isRunning;

        public DateTime StartTime => _startTime ?? DateTime.MinValue;
    }
}