using Belatrix.CodeReview.Interfaces;
using System;
using static Belatrix.CodeReview.Common.Enums;

namespace Belatrix.CodeReview
{
    public class ConsoleLogger : IMessageLogger, IWarningLogger, IErrorLogger
    {
        public ConsoleLogger(string message)
        {
            _message = message;
        }

        private string GetMessageToLog()
            => DateTime.Now.ToShortDateString() + _message;

        public LoggerResult LogMessage()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Message: {GetMessageToLog()}");

            return LoggerResult.Success;
        }

        public LoggerResult LogWarningMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Warning: {GetMessageToLog()}");

            return LoggerResult.Success;
        }

        public LoggerResult LogErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: {GetMessageToLog()}");

            return LoggerResult.Success;
        }

        private string _message;
    }
}
