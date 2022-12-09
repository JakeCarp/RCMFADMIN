namespace rcmfadmin.Services;

public class TeamsService
{
  private readonly TeamsRepository _teamsRepo;

  public TeamsService(TeamsRepository teamsRepo)
  {
    _teamsRepo = teamsRepo;
  }
}