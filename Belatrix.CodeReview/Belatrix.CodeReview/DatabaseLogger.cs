using Belatrix.CodeReview.Interfaces;
using System.Configuration;
using System.Data.SqlClient;
using static Belatrix.CodeReview.Common.Enums;

namespace Belatrix.CodeReview
{
    public class DatabaseLogger : IMessageLogger, IWarningLogger, IErrorLogger
    {
        public DatabaseLogger(string message)
        {
            _message = message;
        }

        private SqlConnection GetConnection()
            => new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);

        private SqlCommand GetCommand()
            => new SqlCommand($"Insert into Log Values('{ _message }', {_messageType})");

        public LoggerResult LogMessage()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                _messageType = 1;
                GetCommand().ExecuteNonQuery();
                connection.Close();
            }

            return LoggerResult.Success;
        }

        public LoggerResult LogWarningMessage()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                _messageType = 2;
                GetCommand().ExecuteNonQuery();
                connection.Close();
            }

            return LoggerResult.Success;
        }

        public LoggerResult LogErrorMessage()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                _messageType = 3;
                GetCommand().ExecuteNonQuery();
                connection.Close();
            }

            return LoggerResult.Success;
        }

        private string _message;
        private int _messageType;
    }
}
