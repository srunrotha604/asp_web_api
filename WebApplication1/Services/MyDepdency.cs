public class MyDependency(ILogger<MyDependency> logger) : IMessage
{
    public void ShowMessage(string message)
    {
        logger.LogInformation(message);
    }
}
