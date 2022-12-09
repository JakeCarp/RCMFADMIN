namespace rcmfadmin.Repositories;

public class NewsletterRepository : BaseRepository, IRepo<NewsLetter, int>
{
  public NewsletterRepository(IDbConnection db) : base(db)
  {
  }

  public NewsLetter Create(NewsLetter newsLetterData)
  {
    var sql = @"INSERT INTO newsLetters
                (name,email)
                VALUES
                (@Name,@Email);
                SELECT LAST_INSERT_ID()
                ;";

    int newsLetterId = _db.ExecuteScalar<int>(sql, newsLetterData);
    return GetById(newsLetterId);
  }

  public void Delete(int id)
  {
    var sql = @"DELETE FROM newsLetters WHERE id = @id;";

    var rows = _db.Execute(sql, new { id });
    if (rows != 1) { throw new Exception("unable to delete newsletter properly"); }
    return;

  }

  public List<NewsLetter> Get()
  {
    string sql = @"SELECT 
              *
              FROM newsLetters;";
    return _db.Query<NewsLetter>(sql).ToList();
  }

  public NewsLetter GetById(int id)
  {
    string sql = @"SELECT 
                *
                FROM newsLetters
                WHERE id = @id
                ;";
    return _db.Query<NewsLetter>(sql, new { id }).FirstOrDefault();
  }

  public NewsLetter Update(NewsLetter data)
  {
    throw new NotImplementedException();
  }

  internal NewsLetter GetByNameAndEmail(NewsLetter newsletterData)
  {
    string sql = @"SELECT 
              *
              FROM newsLetters
              WHERE name = @name and email = @email
                   ;";
    return _db.Query<NewsLetter>(sql, newsletterData).FirstOrDefault();
  }
}