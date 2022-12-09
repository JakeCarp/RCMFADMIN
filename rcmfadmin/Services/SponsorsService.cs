namespace rcmfadmin.Services;

public class SponsorsService
{
  private readonly SponsorsRepository _sponsorsRepo;
  private readonly AccountService _accountsService;

  public SponsorsService(SponsorsRepository sponsorsRepo, AccountService accountsService)
  {
    _sponsorsRepo = sponsorsRepo;
    _accountsService = accountsService;
  }

  internal List<Sponsor> GetAllSponsors(string adminId)
  {
    Account admin = _accountsService.GetAdminById(adminId);

    return _sponsorsRepo.Get();
  }

  internal void DeleteSponsor(int sponsorId, string userId)
  {
    Account admin = _accountsService.GetAdminById(userId);
    Sponsor sponsor = _sponsorsRepo.GetById(sponsorId);
    _sponsorsRepo.Delete(sponsorId);
  }

  internal Sponsor GetSponsorById(int sponsorId)
  {
    // Account admin = _accountsService.GetAdminById(userId);
    Sponsor sponsor = _sponsorsRepo.GetById(sponsorId);
    if (sponsor == null)
    {
      throw new Exception("Bad Sponsor Id");
    }
    return sponsor;
  }

  internal Sponsor UpdateSponsor(Sponsor sponsor, string accountId)
  {
    Account admin = _accountsService.GetAdminById(accountId);

    Sponsor original = GetSponsorById(sponsor.Id);

    original.Name = sponsor.Name ?? original.Name;
    original.Email = sponsor.Email ?? original.Email;
    original.Tier = sponsor.Tier;

    Sponsor updated = _sponsorsRepo.Update(original);
    return updated;

  }

  internal Sponsor CreateSponsor(Sponsor sponsorData)
  {
    return _sponsorsRepo.Create(sponsorData);
  }


}