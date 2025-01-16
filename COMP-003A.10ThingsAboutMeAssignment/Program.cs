namespace COMP_003A._10ThingsAboutMeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "! My name is Gauge!"); // Initial Greeting
            Console.WriteLine("Here are 10 things about me:"); // 10 things about me opening
            Console.WriteLine(  "\t 1. I am a Mechanical Engineering Major at Lemoore College. \n" +
                                "\t 2. I am from Lemoore. \n" +
                                "\t 3. I am 19 years old. \n" +
                                "\t 4. I am a semi professional racecar driver. \n" +
                                "\t 5. I enjoy playing cornhole. \n" +
                                "\t 6. I have 1 sibling. \n" +
                                "\t 7. I am a diehard Dallas Cowboys fan sadly. \n" +
                                "\t 8. I drive a 14' Silverado 1500. \n" +
                                "\t 9. I like to sportsbet. (RESPONSIBLY) \n"+
                                "\t 10. I love most music genres besides hard rock."); // 10 things about me list
        }
    }
}
