// Fig. 8.2: TimeTest1.cs
// Demonstrating class Time1.

using System;
using System.Windows.Forms;

namespace TimeTest1
{
    // TimeTest1 uses creates and uses a Time1 object
    class TimeTest1
    {
        // main entry point for application
        static void Main(string[] args)
        {
            Time2 time = new Time2();
            try
            {
                time.SetTime(-13, 27, 6);
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                MessageBox.Show("Error: " + outOfRange.Message);
            }
            string output = "After SetTime(-13, 27, 6) your time is - " + time.Time.ToString();
            output += "\nYou should have recieved an error box!";
            try
            {
                time.SetTime(13, 27, 6);
            }
            catch (ArgumentOutOfRangeException outOfRange)
            {
                MessageBox.Show("Error: " + outOfRange.Message);
            }

            output += "\nAfter SetTime(13, 27, 6) your time is - " + time.Time.ToString();
            output += "\nAfter converting it to Universal your time is - " + time.ToUniversalString();
            output += "\nAfter converting it to Standard your time is - " + time.ToStandardString();

            MessageBox.Show(output);
          




            /*
            // assign string representation of time to output
            output = "Initial universal time is: " +
               time.ToUniversalString() +
               "\nInitial standard time is: " +
               time.ToStandardString();

            // attempt valid time settings
            time.SetTime(13, 27, 6);

            // append new string representations of time to output
            output += "\n\nUniversal time after SetTime is: " +
               time.ToUniversalString() +
               "\nStandard time after SetTime is: " +
               time.ToStandardString();

           // time.Minute = 45;

            //int duck = time.Minute;

            // attempt invalid time settings
            time.SetTime(99, 99, 99);

            output += "\n\nAfter attempting invalid settings: " +
               "\nUniversal time: " + time.ToUniversalString() +
               "\nStandard time: " + time.ToStandardString();

            MessageBox.Show(output, "Testing Class Time1");*/

        } // end method Main

    } // end class TimeTest1
}
