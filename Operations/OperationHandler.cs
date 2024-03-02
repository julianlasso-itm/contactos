namespace HolaMundo.Operations;

public abstract class OperationHandler<Model>
{
    public abstract OperationBase<Model> CreateOperation();

    public void Operate()
    {
        OperationBase<Model> operation = CreateOperation();
        operation.Execute();
    }
}
