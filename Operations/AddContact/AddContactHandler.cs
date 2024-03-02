namespace HolaMundo.Operations.AddContact;

public class AddContactHandler : OperationHandler
{
  public override IOperation CreateOperation()
  {
    return new AddContactOperation();
  }
}
