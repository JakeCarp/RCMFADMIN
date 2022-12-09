namespace rcmfadmin.Models;
public class Grant : IDbItem<int>
{


  public int Id { get; set; }
  public int Amount { get; set; }
  public string Name { get; set; }
  public string Email { get; set; }
  public string Department { get; set; }
  public string Description { get; set; }
  public int Budget { get; set; } //needs to be a file?
  public string TrainingProvider { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
}
