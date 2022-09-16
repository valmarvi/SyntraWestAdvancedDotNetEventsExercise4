using System;

namespace SyntraWestAdvancedDotNetEventsExercise4
{
    class Bucket
    {
        public int _maxAmount { get; set; }
        private int _currentAmount { get; set; }
        public event EventHandler AlmostFull;
        public event EventHandler Full;

        public Bucket(int maxAmount)
        {
            _maxAmount = maxAmount;
        }

        public void Fill(int _amount)
        {
            _currentAmount += _amount;

            if (_currentAmount < 0.8 * _maxAmount)
            {
                _currentAmount += _amount;
            }
            else if (_currentAmount >= 0.8 * _maxAmount && _currentAmount < _maxAmount)
            {
                AlmostFull.Invoke(this, null);
            }
            else
            {
                Full.Invoke(this, null);
            }
        }
    }
}
