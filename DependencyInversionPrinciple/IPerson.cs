namespace DependencyInversionPrinciple
{
    internal interface IPerson
    {
        string Address { get; set; }
        int Age { get; set; }
        int Id { get; set; }
        string Name { get; set; }
    }
}