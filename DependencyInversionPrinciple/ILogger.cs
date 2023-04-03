namespace DependencyInversionPrinciple
{
    internal interface ILogger
    {
        void LoginMessage(IPerson person, string message);
    }
}