namespace HolaMundo.Operations.ListContacts;

public class ListContactsOperation : IOperation
{
    public void Inject()
    {
        Console.WriteLine("Injecting ListContactsOperation");
    }

    public void Execute()
    {
        Console.WriteLine("Executing ListContactsOperation");
    }
}
