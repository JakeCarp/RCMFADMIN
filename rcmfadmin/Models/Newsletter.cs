namespace rcmfadmin.Models;

public class NewsLetter : IDbItem<int>
{
  public string Name { get; set; }
  public string Email { get; set; }
  public int Id { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
}