using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Belatrix.CodeReview.Common.Enums;

namespace Belatrix.CodeReview.Tests
{
    [TestClass()]
    public class DatabaseLoggerTests
    {
        [TestMethod()]
        public void Should_Success_When_DatabaseLogMessage()
        {
            //Arrange
            var databaseLogger = new DatabaseLogger("Log Message");
            //Act
            var result = databaseLogger.LogMessage();
            //Assert
            Assert.AreEqual(result, LoggerResult.Success);
        }

        [TestMethod()]
        public void Should_Success_When_DatabaseLogWarningMessage()
        {
            //Arrange
            var databaseLogger = new DatabaseLogger("Log Warning Message");
            //Act
            var result = databaseLogger.LogWarningMessage();
            //Assert
            Assert.AreEqual(result, LoggerResult.Success);
        }

        [TestMethod()]
        public void Should_Success_When_DatabaseLogErrorMessage()
        {
            //Arrange
            var databaseLogger = new DatabaseLogger("Log Error Message");
            //Act
            var result = databaseLogger.LogErrorMessage();
            //Assert
            Assert.AreEqual(result, LoggerResult.Success);
        }
    }
}