namespace HolaMundo;

public interface IDataBase
{
    void AddContact(Contact contact);
    void RemoveContact(String email);
    void UpdateContact(Contact contact);
    List<Contact> GetContacts();
}
