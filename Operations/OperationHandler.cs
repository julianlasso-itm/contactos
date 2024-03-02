namespace HolaMundo.Operations;

public abstract class OperationHandler
{
    public abstract IOperation CreateOperation();

    public void Operate()
    {
        IOperation operation = CreateOperation();
        operation.Inject();
        operation.Execute();
    }
}
