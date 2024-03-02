namespace HolaMundo.Operations.ListContacts;

public class ListContactsHandler : OperationHandler
{
    public override IOperation CreateOperation()
    {
        return new ListContactsOperation();
    }
}
