namespace HolaMundo;

public class DataBase : IDataBase
{
    private readonly List<Contact> _contacts = new List<Contact>();

    public void AddContact(Contact contact)
    {
        _contacts.Add(contact);
    }

    public void RemoveContact(String email)
    {
        var contact = _contacts.Find(c => c.Email == email);
        if (contact == null)
            throw new InvalidOperationException("Contact not found");
        _contacts.Remove(contact);
    }

    public void UpdateContact(Contact contact)
    {
        var index = _contacts.FindIndex(c => c.Id == contact.Id);
        if (index == -1)
            throw new InvalidOperationException("Contact not found");
        _contacts[index] = contact;
    }

    public List<Contact> GetContacts()
    {
        return _contacts;
    }
}