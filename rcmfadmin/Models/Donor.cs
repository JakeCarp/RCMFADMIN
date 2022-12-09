namespace rcmfadmin.Models;


public class Donor : IDbItem<int>
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string Email { get; set; }
  public int? Amount { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
}
