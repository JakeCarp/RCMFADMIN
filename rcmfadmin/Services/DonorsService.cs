namespace rcmfadmin.Services;

public class DonorsService
{
  private readonly DonorsRepository _donorsRepo;
  private readonly AccountService _accountService;

  public DonorsService(DonorsRepository donorsRepo, AccountService accountService)
  {
    _donorsRepo = donorsRepo;
    _accountService = accountService;
  }

  internal Donor CreateDonor(Donor donorData)
  {
    return _donorsRepo.Create(donorData);
  }
  internal Donor GetDonor(int donorId)
  {
    Donor donor = _donorsRepo.GetById(donorId);
    if (donor == null)
    {
      throw new Exception("Donor not found");
    }
    return donor;
  }

  internal void DeleteDonor(int donorId, string id)
  {
    Account admin = _accountService.GetAdminById(id);
    Donor donor = GetDonor(donorId);
    _donorsRepo.Delete(donor.Id);

  }

  internal List<Donor> GetAllDonors(string adminId)
  {
    Account admin = _accountService.GetAdminById(adminId);
    return _donorsRepo.Get();
  }

  internal Donor EditDonor(Donor donorData, string adminId)
  {
    Account admin = _accountService.GetAdminById(adminId);
    Donor original = GetDonor(donorData.Id);
    original.Amount = donorData.Amount ?? original.Amount;
    original.Name = donorData.Name ?? original.Name;
    original.Email = donorData.Email ?? original.Email;
    return _donorsRepo.Update(original);
  }
}