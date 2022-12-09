
namespace rcmfadmin.Models;

public class Sponsor : IDbItem<int>
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string Email { get; set; }
  public SponsorTier Tier { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
}
