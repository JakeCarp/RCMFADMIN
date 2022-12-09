namespace rcmfadmin.Repositories;
public abstract class BaseRepository
{
  protected readonly IDbConnection _db;

  public BaseRepository(IDbConnection db)
  {
    _db = db;
  }
}