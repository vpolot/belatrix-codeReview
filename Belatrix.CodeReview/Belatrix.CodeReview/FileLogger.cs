using Belatrix.CodeReview.Interfaces;
using System;
using System.Configuration;
using System.IO;
using static Belatrix.CodeReview.Common.Enums;

namespace Belatrix.CodeReview
{
    public class FileLogger : IMessageLogger, IWarningLogger, IErrorLogger
    {
        public FileLogger(string message)
        {
            _message = message;
        }

        public LoggerResult LogMessage()
        {
            _logFile = $"Message: {SetFileToLog()}";
            WriteFileIfExists();

            return LoggerResult.Success;
        }

        public LoggerResult LogWarningMessage()
        {
            _logFile = $"Warning: {SetFileToLog()}";
            WriteFileIfExists();

            return LoggerResult.Success;
        }

        public LoggerResult LogErrorMessage()
        {
            _logFile = $"Error: {SetFileToLog()}";
            WriteFileIfExists();

            return LoggerResult.Success;
        }

        private bool FileExists()
            => File.Exists(LogFileName);

        private string ReadFile()
            => File.ReadAllText(LogFileName);

        private string SetFileToLog()
            => $"{ReadFile()}{DateTime.Now.ToShortDateString()}{_message}";

        private void WriteFile()
            => File.WriteAllText(LogFileName, _logFile);

        private void WriteFileIfExists()
        {
            if (!FileExists())
                return;

            WriteFile();
        }

        private string _message;
        private string _logFile;
        private string LogFileDirectory => ConfigurationManager.AppSettings["LogFileDirectory"];
        private string LogFileName => $"{LogFileDirectory}LogFile{DateTime.Now.ToShortDateString()}.txt";
    }
}
