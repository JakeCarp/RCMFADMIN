namespace rcmfadmin.Repositories;

public class DonorsRepository : BaseRepository, IRepo<Donor, int>
{
  public DonorsRepository(IDbConnection db) : base(db)
  {
  }

  public Donor Create(Donor data)
  {
    var sql = @"INSERT INTO donors (name, email, amount)
            VALUES (@Name, @Email, @Amount);
            SELECT LAST_INSERT_ID()
            ;";

    int donorId = _db.ExecuteScalar<int>(sql, data);
    return GetById(donorId);
  }

  public void Delete(int id)
  {
    var sql = @"DELETE FROM donors WHERE id = @id limit 1;";

    var rows = _db.Execute(sql, new { id });
    if (rows != 1) { throw new Exception("unable to delete properly"); }
    return;

  }

  public List<Donor> Get()
  {
    string sql = @"SELECT 
                  *
                  FROM donors 
                  ORDER BY donors.createdAt DESC
                  ;";

    return _db.Query<Donor>(sql).ToList();

  }

  public Donor GetById(int id)
  {
    string sql = @"SELECT 
                *
                FROM donors
                WHERE id = @id
                     ;";
    return _db.Query<Donor>(sql, new { id }).FirstOrDefault();
  }

  public Donor Update(Donor donorData)
  {
    string sql = @"UPDATE donors SET
                  name = @name,
                  email = @email,
                  amount = @amount
                  WHERE id = @Id LIMIT 1
                       ;";
    var rows = _db.Execute(sql, donorData);
    if (rows != 1)
    {
      throw new Exception("Unable to update");
    }

    return GetById(donorData.Id);
  }
}