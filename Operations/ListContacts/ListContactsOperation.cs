using HolaMundo.DataBase;
using HolaMundo.DataBase.Models;

namespace HolaMundo.Operations.ListContacts;

public class ListContactsOperation : OperationBase<Contact>
{
    public ListContactsOperation(IDataBase<Contact> dataBase) : base(dataBase) { }

    public override void Execute()
    {
        var contacts = _dataBase.GetContacts();
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts found");
        }
        else
        {
            Console.WriteLine("Contacts:");
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Id: {contact.Id}, Name: {contact.Name}, Email: {contact.Email}, Phone: {contact.Phone}");
            }
        }
    }
}
