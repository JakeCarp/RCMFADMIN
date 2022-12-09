namespace rcmfadmin.Services;

public class PlayersService
{
  private readonly PlayersRepository _playersRepo;

  public PlayersService(PlayersRepository playersRepo)
  {
    _playersRepo = playersRepo;
  }

  internal Player CreatePlayer(Player playerData)
  {
    Player player = _playersRepo.GetByNameAndEmail(playerData);
    if (player != null)
    {
      throw new Exception("player already added");
    }

    return _playersRepo.Create(playerData);


  }
}