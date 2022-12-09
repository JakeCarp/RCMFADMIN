namespace rcmfadmin.Repositories;

public class GrantsRepository : BaseRepository, IRepo<Grant, int>
{
  public GrantsRepository(IDbConnection db) : base(db)
  {
  }

  public Grant Create(Grant data)
  {
    throw new NotImplementedException();
  }

  public void Delete(int id)
  {
    throw new NotImplementedException();
  }

  public List<Grant> Get()
  {
    throw new NotImplementedException();
  }

  public Grant GetById(int id)
  {
    throw new NotImplementedException();
  }

  public Grant Update(Grant data)
  {
    throw new NotImplementedException();
  }
}