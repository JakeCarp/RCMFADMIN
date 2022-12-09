namespace rcmfadmin.Models;
public class Tournament
{
  public int Id { get; set; }
  public DateTime? Date { get; set; }
  public string Location { get; set; }
  public bool Archived { get; set; } = false;
  public int? NetIncome { get; set; }

}
