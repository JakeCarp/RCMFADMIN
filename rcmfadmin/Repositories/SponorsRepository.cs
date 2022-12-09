namespace rcmfadmin.Repositories;

public class SponsorsRepository : BaseRepository, IRepo<Sponsor, int>
{
  public SponsorsRepository(IDbConnection db) : base(db)
  {
  }

  public Sponsor Create(Sponsor data)
  {
    var sql = @"
    INSERT INTO
    sponsors (name, email, tier)
    VALUES (@Name, @Email, @Tier);
    SELECT LAST_INSERT_ID()
    ;";

    int sponsorId = _db.ExecuteScalar<int>(sql, data);
    return GetById(sponsorId);
  }

  public void Delete(int id)
  {
    var sql = @"
    DELETE FROM 
    sponsors
    WHERE
    id = @id
    ;";

    var rows = _db.Execute(sql, new { id });
    if (rows != 1) { throw new Exception("Data is bad or Id is Bad"); }
    return;
  }

  public List<Sponsor> Get()
  {
    string sql = @"
    SELECT *
    FROM
    sponsors
    ORDER BY sponsors.createdAt DESC
    ;";
    return _db.Query<Sponsor>(sql).ToList();
  }

  public Sponsor GetById(int id)
  {
    var sql = @"
    SELECT *
    FROM sponsors
    WHERE id = @id
    ;";
    return _db.Query<Sponsor>(sql, new { id }).FirstOrDefault();
  }

  public Sponsor Update(Sponsor data)
  {
    string sql = @"
    UPDATE sponsors SET
    name = @Name,
    email = @Email,
    tier = @Tier,
    WHERE id = @Id LIMIT 1
    ;";
    var rows = _db.Execute(sql, data);
    if (rows != 1)
    {
      throw new Exception("Unable to update");
    }

    int sponsorId = _db.ExecuteScalar<int>(sql, data);
    return GetById(sponsorId);
  }

}