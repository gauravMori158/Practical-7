namespace DependencyInversionPrinciple
{
    internal interface ILogger
    {
        string LoginMessage(IPerson person, string message);
    }
}