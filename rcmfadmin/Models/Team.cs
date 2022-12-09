namespace rcmfadmin.Models;

public class Team
{

  public int Id { get; set; }
  public int Phone { get; set; }
  public string Name { get; set; }
  public string Email { get; set; }

  //--virtuals--//
  public int SponsorId { get; set; }
  public int TournamentId { get; set; }

}
