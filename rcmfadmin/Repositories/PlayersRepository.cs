namespace rcmfadmin.Repositories;

public class PlayersRepository : BaseRepository, IRepo<Player, int>
{
  public PlayersRepository(IDbConnection db) : base(db)
  {
  }

  public Player Create(Player playerData)
  {
    var sql = @"INSERT INTO players(name, email, shirtSize, teamId)
              VALUES(@Name, @Email, @ShirtSize, @TeamId);
              SELECT LAST_INSERT_ID()
                  ;";

    int playerId = _db.ExecuteScalar<int>(sql, playerData);
    return GetById(playerId);
  }

  public void Delete(int id)
  {
    var sql = @"DELETE FROM players WHERE id = @id;";

    int rows = _db.Execute(sql, new { id });
    if (rows != 1) { throw new Exception("unable to delete player properly"); }
    return;

  }

  public List<Player> Get()
  {
    throw new NotImplementedException();
  }

  public Player GetById(int playerId)
  {
    string sql = @"SELECT 
                *
                FROM players
                WHERE id = @playerId
                     ;";
    return _db.Query<Player>(sql, new { playerId }).FirstOrDefault();
  }

  public Player Update(Player data)
  {
    throw new NotImplementedException();
  }

  internal Player GetByNameAndEmail(Player playerData)
  {
    string sql = @"SELECT 
                *
                FROM players
                WHERE name = @name and email = @email
                     ;";
    return _db.Query<Player>(sql, new { playerData }).FirstOrDefault();
  }
}