using System;

namespace Entities
{
    public class DefaultSpeed
    {
        public int MinValuePermitted { get; private set; }

        public int MaxValuePermitted { get; private set; }

        public int Value { get; private set; }

        private readonly int _constMult = 7;

        public DefaultSpeed(int trackBarSpeedMax, int trackBarSpeedMin, int currentValue)
        {
            SetMinValuePermitted(trackBarSpeedMin);
            SetMaxValuePermitted(trackBarSpeedMax);
            SetValue(currentValue);
        }



        public void SetValue(int trackBarSpeedValue)
        {
            // Timer1 milliseconds interval ( [1ms] or [2ms * _constMult] , [3ms * _constMult] , [4ms * _constMult] ...)
            if (trackBarSpeedValue == 1)
                Value = trackBarSpeedValue;
            else
                Value = trackBarSpeedValue * _constMult;
        }

        public void IncreaseValue()
        {
            if (Value == 1)
                Value = _constMult * 2;
            else
                Value += _constMult;
        }

        public void DecreaseValue()
        {
            decimal CurrentValueCheck = Math.Ceiling((decimal)Value / (_constMult * 2));

            if (CurrentValueCheck == 1)
                Value = 1;
            else
                Value -= _constMult;
        }

        private void SetMinValuePermitted(int minValue)
        {
            if (minValue == 1)
                MinValuePermitted = minValue;
            else
                MinValuePermitted = minValue * _constMult;
        }

        private void SetMaxValuePermitted(int maxValue)
        {
            if (maxValue == 1)
                MaxValuePermitted = maxValue;
            else
                MaxValuePermitted = maxValue * _constMult;
        }


    }
}
