namespace HolaMundo.DataBase.Models;

public class Contact
{
    public Guid Id { get; set; }
    public required String Name { get; set; }
    public required String Email { get; set; }
    public required String Phone { get; set; }
}
