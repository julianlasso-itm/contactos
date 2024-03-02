using HolaMundo.DataBase;
using HolaMundo.DataBase.Models;

namespace HolaMundo.Operations.AddContact;

public class AddContactOperation : OperationBase<Contact>
{
    public AddContactOperation(IDataBase<Contact> dataBase) : base(dataBase) { }

    public override void Execute()
    {
        var contact = new Contact();

        Console.WriteLine("Ingrese el nombre del contacto: ");
        contact.Name = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Ingrese el número del contacto: ");
        contact.Phone = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Ingrese el correo del contacto: ");
        contact.Email = Console.ReadLine() ?? string.Empty;

        _dataBase.AddContact(contact);
    }
}
