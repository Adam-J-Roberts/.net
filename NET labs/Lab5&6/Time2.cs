// Class Time2 maintains time in a sec from midnight format.

using System;

namespace TimeTest1
{
  
    public class Time2
    {


        // Time1 constructor initializes instance variables to 
        // zero to set default time to midnight
        public Time2(int hr=0, int mn=0, int sec=0)
        {
            SetTime(hr, mn, sec);
        }

        // Set new time value in 24-hour format. Perform validity
        // checks on the data. Set invalid values to zero.
        public void SetTime(
           int hourValue, int minuteValue, int secondValue)
        {
            if (hourValue < 0 || minuteValue < 0 || secondValue < 0)
            {
                throw new ArgumentOutOfRangeException("Time", "All times must be in proper range");
            }
            else
            {
                int hour = hourValue * 3600;
                int minute = minuteValue * 60;
                int second = secondValue;
                sec2Mid = hour + minute + second;
            }
        } // end method SetTime

        // convert time to universal-time (24 hour) format string
        public string ToUniversalString()
        {
            int hour2 = sec2Mid/3600;
            int minute2 = (sec2Mid % 3600) / 60;
            int second2 = (sec2Mid % 3600) % 60;

            return String.Format(
               "{0:D2}:{1:D2}:{2:D2}", hour2, minute2, second2);
        }

        // convert time to standard-time (12 hour) format string
        public string ToStandardString()
        {
            int hour2 = sec2Mid / 3600;
            if (hour2 > 12) { hour2 = hour2 - 12; }
            int minute2 = (sec2Mid % 3600) / 60;
            int second2 = (sec2Mid % 3600) % 60;

            return String.Format("{0}:{1:D2}:{2:D2} {3}",
               ((hour2 == 12 || hour2 == 0) ? 12 : hour2 % 12),
               minute2, second2, (hour2 < 12 ? "PM" : "AM"));
        }
        public int Time
        {  
            get{   return sec2Mid; }
            set{   sec2Mid = value;}
        }

        private int sec2Mid;
    } // end class Time1
}
