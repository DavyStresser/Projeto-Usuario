namespace GISA.Model;

public class UserViewModel
{
    public int Id { get; set; }
    public string Username { get; set; } = null!;
    public string Name { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
}
