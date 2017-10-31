using static Belatrix.CodeReview.Common.Enums;

namespace Belatrix.CodeReview.Interfaces
{
    public interface IErrorLogger
    {
        LoggerResult LogErrorMessage();
    }
}
