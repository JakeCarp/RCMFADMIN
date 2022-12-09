namespace rcmfadmin.Services;

public class TournamentsService
{
  private readonly TournamentsRepository _tournamentRepo;
  private readonly AccountService _accountsService;

  public TournamentsService(TournamentsRepository tournamentRepo, AccountService accountsService)
  {
    _tournamentRepo = tournamentRepo;
    _accountsService = accountsService;
  }

  internal Tournament CreateTournament(Tournament tourneyData)
  {
    return _tournamentRepo.Create(tourneyData);
  }

  internal void ArchiveTourney(int tourneyId, string userId)
  {
    Account admin = _accountsService.GetAdminById(userId);
    Tournament tourney = _tournamentRepo.GetById(tourneyId);
    if (tourney.Archived)
    {
      throw new Exception("Tournament is already archived");
    }
    tourney.Archived = true;
    _tournamentRepo.Delete(tourneyId);
  }

  internal List<Tournament> GetAllTournaments(string adminId)
  {
    Account admin = _accountsService.GetAdminById(adminId);
    return _tournamentRepo.Get();
  }

  internal Tournament GetTourneyById(int tourneyId)
  {
    Tournament tourney = _tournamentRepo.GetById(tourneyId);
    if (tourney == null)
    {
      throw new Exception("Bad Tournament Id");
    }
    return tourney;
  }

  internal Tournament UpdateTourney(Tournament tourney, string accountId)
  {
    Account admin = _accountsService.GetAdminById(accountId);

    Tournament original = GetTourneyById(tourney.Id);

    original.Date = tourney.Date ?? original.Date;
    original.Location = tourney.Location ?? original.Location;
    original.NetIncome = tourney.NetIncome ?? original.NetIncome;

    Tournament updated = _tournamentRepo.Update(original);
    return updated;
  }
}