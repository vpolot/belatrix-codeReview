using static Belatrix.CodeReview.Common.Enums;

namespace Belatrix.CodeReview.Interfaces
{
    public interface IWarningLogger
    {
        LoggerResult LogWarningMessage();
    }
}
