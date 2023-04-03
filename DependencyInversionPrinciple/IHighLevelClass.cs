namespace DependencyInversionPrinciple
{
    internal interface IHighLevelClass
    {
        string Message { get; set; }
        IPerson person { get; set; }

        void MailSender();
        void PrintUser();
    }
}