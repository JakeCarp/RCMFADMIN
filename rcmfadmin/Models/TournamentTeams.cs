namespace rcmfadmin.Models;

public class TournamentTeams
{
  public Tournament Tournament { get; set; }
  public List<Team> Teams { get; set; }
}
