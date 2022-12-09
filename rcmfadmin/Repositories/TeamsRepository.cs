namespace rcmfadmin.Repositories;

public class TeamsRepository : BaseRepository, IRepo<Team, int>
{
  public TeamsRepository(IDbConnection db) : base(db)
  {
  }

  public Team Create(Team teamData)
  {
    var sql = @"INSERT INTO teams
              (name)
            VALUES (@Name);
            SELECT LAST_INSERT_ID()
                ;";

    int TeamId = _db.ExecuteScalar<int>(sql, teamData);
    return GetById(TeamId);
  }

  public void Delete(int id)
  {
    var sql = @"DELETE FROM teams WHERE id = @id;";

    var rows = _db.Execute(sql, new { id });
    if (rows != 1) { throw new Exception("Data is bad or Id is Bad"); }
    return;

  }

  public List<Team> Get()
  {
    throw new NotImplementedException();
  }

  public Team GetById(int teamsId)
  {
    string sql = @"SELECT 
                *
                FROM  teams
                WHERE id = @teamsId
                     ;";
    return _db.Query<Team>(sql, new { teamsId }).FirstOrDefault();
  }

  public Team Update(Team teamData)
  {
    string sql = @"UPDATE teams SET
                  name = @name,
                  WHERE id = @Id LIMIT 1
                       ;";
    var rows = _db.Execute(sql, teamData);
    if (rows != 1) { throw new Exception("Unable to update"); }
    return GetById(teamData.Id);
  }
}