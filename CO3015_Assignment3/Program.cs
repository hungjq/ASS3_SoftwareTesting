namespace CO3015_Assignment3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            B06BlockUser driverB06 = new B06BlockUser();
            driverB06.RunTest();

            B05AddCalendarEvent driverB05 = new B05AddCalendarEvent();
            driverB05.RunTest();
        }
    }
}