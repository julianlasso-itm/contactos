namespace HolaMundo.DataBase.Models;

public class Contact : IModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public String Name { get; set; } = String.Empty;
    public String Email { get; set; } = String.Empty;
    public String Phone { get; set; } = String.Empty;
}
