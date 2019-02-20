using System;

namespace kshrTools
{
    class kshrOutput
    {
        private void sendMessage (string message, string msgchar, ConsoleColor color) {
            ConsoleColor previousColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            string[] splitMessage = message.Split("\n");
            foreach (string msg in splitMessage) {
                if (Array.IndexOf(splitMessage, msg) == 0)
                    Console.WriteLine("{0}{0} " + msg, msgchar);
                else
                    Console.WriteLine("   " + msg);
            }
            Console.ForegroundColor = previousColor;
        }

        private void sendMessage (string message, string sender, string msgchar, ConsoleColor color) {
            ConsoleColor previousColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            string[] splitMessage = message.Split("\n");
            foreach (string msg in splitMessage) {
                if (Array.IndexOf(splitMessage, msg) == 0)
                    Console.WriteLine("{0}{1}{0} " + msg, msgchar, sender);
                else
                    Console.WriteLine("   " + msg);
            }
            Console.ForegroundColor = previousColor;
        }
        public void info (string message)
        {
            sendMessage(message, ":", ConsoleColor.Blue);
        }

        public void info (string message, string sender)
        {
            sendMessage(message, sender, ":", ConsoleColor.Blue);
        }

        public void error (string message)
        {
            sendMessage(message, "!", ConsoleColor.Red);
        }

        public void error (string message, string sender)
        {
            sendMessage(message, sender, "!", ConsoleColor.Red);
        }

        public void warning (string message)
        {
            sendMessage(message, ".", ConsoleColor.Yellow);
        }

        public void warning (string message, string sender)
        {
            sendMessage(message, sender, ".", ConsoleColor.Yellow);
        }

        public void success (string message)
        {
            sendMessage(message, "#", ConsoleColor.Green);
        }

        public void success (string message, string sender)
        {
            sendMessage(message, sender, "#", ConsoleColor.Green);
        }
    }
}