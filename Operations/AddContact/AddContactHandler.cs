using HolaMundo.DataBase;
using HolaMundo.DataBase.Models;

namespace HolaMundo.Operations.AddContact;

public class AddContactHandler : OperationHandler<Contact>
{
  private readonly IDataBase<Contact> _dataBase;

  public AddContactHandler(IDataBase<Contact> dataBase)
  {
    _dataBase = dataBase;
  }

  public override OperationBase<Contact> CreateOperation()
  {
    return new AddContactOperation(_dataBase);
  }
}
