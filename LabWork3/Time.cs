using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v3
{
    public class Time
    {
        private int hr, mn, sc;
        public Time()
        {
            hr = 0;
            mn = 0;
            sc = 0;
        }
        public Time(int h, int m, int s)
        {
            hr = h;
            mn = m;
            sc = s;
        }
        public override string ToString()
        {
            return hr.ToString() + ":" + mn.ToString() + ":" + sc.ToString();
        }

        public static Time operator -(Time leftTime, Time rightTime) 
        {
            int leftTotalSec = GetTotalSeconds(leftTime);

            int rightTotalSec = GetTotalSeconds(rightTime);

            int totalSec = leftTotalSec - rightTotalSec;

            Time time = GetTimeFromSeconds(totalSec);

            return time;
        }

        public static Time operator *(Time time, double multiplier)
        {
            int totalSec = GetTotalSeconds(time);

            Time newTime = GetTimeFromSeconds((int)(totalSec * multiplier));

            return newTime;
        }

        public static Time operator *(double multiplier, Time time)
        {
            return time * multiplier;
        }

        private static int GetTotalSeconds(Time time) 
        {
            return time.hr * 3600 + time.mn * 60 + time.sc;
        }

        private static Time GetTimeFromSeconds(int seconds)
        {
            Time time = new Time();

            time.hr = seconds / 3600;

            seconds -= time.hr * 3600;

            time.mn = seconds / 60;

            seconds -= time.mn * 60;

            time.sc = seconds;

            return time;
        }
    }
}
