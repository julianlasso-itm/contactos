using HolaMundo.DataBase;
using HolaMundo.DataBase.Models;

namespace HolaMundo.Operations;

public abstract class OperationBase<Model>
{
    protected IDataBase<Model> _dataBase;

    protected OperationBase(IDataBase<Model> dataBase)
    {
        _dataBase = dataBase;
    }

    public abstract void Execute();
}
