namespace rcmfadmin.Repositories;

public class TournamentsRepository : BaseRepository, IRepo<Tournament, int>
{
  public TournamentsRepository(IDbConnection db) : base(db)
  {
  }

  public Tournament Create(Tournament data)
  {
    var sql = @"
    INSERT INTO
    tournaments (date, location, netIncome)
    VALUES (@Date, @Location, @NetIncome);
    SELECT LAST_INSERT_ID()
    ;";

    int tourneyId = _db.ExecuteScalar<int>(sql, data);
    return GetById(tourneyId);
  }

  public void Delete(int id)
  {
    string sql = @"
      UPDATE tournaments
      SET
      archived = true
      WHERE id = @Id
      ;";
    var rowsAffected = _db.Execute(sql, new { id });
    if (rowsAffected == 0)
    {
      throw new Exception("Unable to update tournaments");
    }
  }

  public List<Tournament> Get()
  {
    string sql = @"
               SELECT 
               *
               FROM tournaments
                    ;
                    ";
    List<Tournament> tournaments = _db.Query<Tournament>(sql).ToList();

    return tournaments;
  }

  public Tournament GetById(int id)
  {
    var sql = @"
    SELECT *
    FROM tournaments
    WHERE id = @id
    ;";
    return _db.Query<Tournament>(sql, new { id }).FirstOrDefault();
  }

  public Tournament Update(Tournament data)
  {
    throw new NotImplementedException();
  }
}