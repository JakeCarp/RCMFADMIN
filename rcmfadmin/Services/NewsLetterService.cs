namespace rcmfadmin.Services;

public class NewsletterService
{
  private readonly NewsletterRepository _newsletterRepo;
  private readonly AccountService _accountsService;

  public NewsletterService(NewsletterRepository newsletterRepo, AccountService accountsService)
  {
    _newsletterRepo = newsletterRepo;
    _accountsService = accountsService;
  }

  internal NewsLetter CreateNewsletter(NewsLetter newsletterData)
  {

    NewsLetter foundLetter = _newsletterRepo.GetByNameAndEmail(newsletterData);
    if (foundLetter != null) { throw new Exception("already subscribed"); }
    NewsLetter newsLetter = _newsletterRepo.Create(newsletterData);
    return newsLetter;
  }
  internal NewsLetter GetNewsletter(int newsLetterId)
  {
    NewsLetter newsLetter = _newsletterRepo.GetById(newsLetterId);
    if (newsLetter == null) { throw new Exception("newsLetter doesnt exist"); }
    return newsLetter;
  }

  internal void DeleteNewsLetter(int newsLetterId, string adminId)
  {
    Account admin = _accountsService.GetAdminById(adminId);
    NewsLetter newsLetter = GetNewsletter(newsLetterId);
    _newsletterRepo.Delete(newsLetter.Id);

  }

  internal List<NewsLetter> GetAllNewsLetters(string adminId)
  {
    Account admin = _accountsService.GetAdminById(adminId);
    return _newsletterRepo.Get();
  }

}