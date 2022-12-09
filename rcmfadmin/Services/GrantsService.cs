namespace rcmfadmin.Services;

public class GrantsService
{
  private readonly GrantsRepository _grantsRepo;

  public GrantsService(GrantsRepository grantsRepo)
  {
    _grantsRepo = grantsRepo;
  }
}