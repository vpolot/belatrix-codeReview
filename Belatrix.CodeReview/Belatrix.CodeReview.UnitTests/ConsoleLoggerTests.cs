using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Belatrix.CodeReview.Common.Enums;

namespace Belatrix.CodeReview.Tests
{
    [TestClass()]
    public class ConsoleLoggerTests
    {
        [TestMethod()]
        public void Should_Success_When_ConsoleLogMessage()
        {
            //Arrange
            var consoleLogger = new ConsoleLogger("Log Message");
            //Act
            var result = consoleLogger.LogMessage();
            //Assert
            Assert.AreEqual(result, LoggerResult.Success);
        }

        [TestMethod()]
        public void Should_Success_When_ConsoleLogWarningMessage()
        {
            //Arrange
            var consoleLogger = new ConsoleLogger("Log Warning Message");
            //Act
            var result = consoleLogger.LogWarningMessage();
            //Assert
            Assert.AreEqual(result, LoggerResult.Success);
        }

        [TestMethod()]
        public void Should_Success_When_ConsoleLogErrorMessage()
        {
            //Arrange
            var consoleLogger = new ConsoleLogger("Log Error Message");
            //Act
            var result = consoleLogger.LogErrorMessage();
            //Assert
            Assert.AreEqual(result, LoggerResult.Success);
        }
    }
}