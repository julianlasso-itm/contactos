namespace HolaMundo.DataBase;

public interface IDataBase<Model>
{
    void AddContact(Model contact);
    void RemoveContact(String email);
    void UpdateContact(Model contact);
    List<Model> GetContacts();
}
