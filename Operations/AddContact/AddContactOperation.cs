namespace HolaMundo.Operations.AddContact;

public class AddContactOperation : IOperation
{
    public void Inject()
    {
        Console.WriteLine("Injecting AddContactOperation");
    }

    public void Execute()
    {
        Console.WriteLine("Executing AddContactOperation");
    }
}
