using System;

namespace Enums
{
    public enum Days                                // to change type-->  Days  : byte
    {
        Monday = 1, Tuesday = 11, Wednessday = 21, Thrusday = 31, Friday = 41           //compiler will assign values to each member starting with zero by default.
    }
    class Program
    {
        public static Days MeetingDate              //property with enum type
        {
            get;
            set;
        } = (Days)1;                                //default meetingdate  or use Days.Monday 


        static void Main(string[] args)
        {
            Days d = (Days)5;
            Console.WriteLine(d);

            d = Days.Thrusday;
            Console.WriteLine((int)d);                                //enum to int conversion

            foreach (int i in Enum.GetValues(typeof(Days)))
               //Console.WriteLine(i);                               //prints values
               Console.WriteLine(i + "  "+ (Days)i);                 //prints values and names
            foreach (string s in Enum.GetNames(typeof(Days)))
               Console.WriteLine(s);                                 //prints names


            Console.WriteLine(MeetingDate);
            MeetingDate = Days.Friday;                      //to change the meeting date we have to choose from options
            Console.WriteLine(MeetingDate);

        }
    }
}
