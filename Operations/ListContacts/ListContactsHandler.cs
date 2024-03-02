using HolaMundo.DataBase;
using HolaMundo.DataBase.Models;

namespace HolaMundo.Operations.ListContacts;

public class ListContactsHandler : OperationHandler<Contact>
{
    private readonly IDataBase<Contact> _dataBase;

    public ListContactsHandler(IDataBase<Contact> dataBase)
    {
        _dataBase = dataBase;
    }

    public override OperationBase<Contact> CreateOperation()
    {
        return new ListContactsOperation(_dataBase);
    }
}
