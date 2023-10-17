namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string severity;
            string message;

            Console.WriteLine("The severity levels are: " + "\u001b[31mHigh" + "\u001b[0m, " + "\u001b[33mWarning " + "\u001b[0m, " + "\u001b[0mInfo " + "\u001b[0m, " + "\u001b[90mDebug" + "\u001b[0m");
            Console.Write("Please enter severity level: ");
            severity = Console.ReadLine();
            Console.Write("Please enter your message: ");
            message = Console.ReadLine();

            ImportanceLevel(severity, message);
        }

        public static void ImportanceLevel(string severity, string message)
        {
            if (severity.ToLower() == "high")
                Console.WriteLine("The severity level is \u001b[31m" + severity.ToLower() + "\u001b[0m. " + "\u001b[0m The message is: " + "\u001b[31m" + message);
            else if (severity.ToLower() == "warning")
                Console.WriteLine("The severity level is \u001b[33m" + severity.ToLower() + "\u001b[0m. " + "\u001b[0m The message is: " + "\u001b[33m" + message);
            else if (severity.ToLower() == "info")
                Console.WriteLine("The severity level is \u001b[0m" + severity.ToLower() + "\u001b[0m. " + "\u001b[0m The message is: " + "\u001b[0m" + message);
            else if (severity.ToLower() == "debug")
                Console.WriteLine("The severity level is \u001b[90m" + severity.ToLower() + "\u001b[0m. " + "\u001b[0m The message is: " + "\u001b[90m" + message);

            Console.WriteLine("\u001b[0m");
        }
    }
}