using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Belatrix.CodeReview.Common.Enums;

namespace Belatrix.CodeReview.Tests
{
    [TestClass()]
    public class FileLoggerTests
    {
        [TestMethod()]
        public void Should_Success_When_FileLogMessage()
        {
            //Arrange
            var fileLogger = new FileLogger("Log Message");
            //Act
            var result = fileLogger.LogMessage();
            //Assert
            Assert.AreEqual(result, LoggerResult.Success);
        }

        [TestMethod()]
        public void Should_Success_When_FileLogWarningMessage()
        {
            //Arrange
            var fileLogger = new FileLogger("Log Warning Message");
            //Act
            var result = fileLogger.LogWarningMessage();
            //Assert
            Assert.AreEqual(result, LoggerResult.Success);
        }

        [TestMethod()]
        public void Should_Success_When_FileLogErrorMessage()
        {
            //Arrange
            var fileLogger = new FileLogger("Log Error Message");
            //Act
            var result = fileLogger.LogErrorMessage();
            //Assert
            Assert.AreEqual(result, LoggerResult.Success);
        }
    }
}