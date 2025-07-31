namespace CadastroUsuarios.API.Models;

public class UserModel
{
    public int Id { get; set; }
    public string Username { get; set; } = null!;
    public string Name { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
}
