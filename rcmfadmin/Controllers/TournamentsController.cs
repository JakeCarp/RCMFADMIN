namespace rcmfadmin.Controllers;

[ApiController]
[Route("[controller]")]
public class TournamentsController : ControllerBase
{
  private readonly Auth0Provider _auth0Provider;
  private readonly TournamentsService _tournamentsService;

  public TournamentsController(Auth0Provider auth0Provider, TournamentsService tournamentsService)
  {
    _auth0Provider = auth0Provider;
    _tournamentsService = tournamentsService;
  }

  [HttpGet]
  [Authorize]
  public async Task<ActionResult<List<Tournament>>> GetAllTournaments()
  {
    try
    {
      Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
      List<Tournament> tourneys = _tournamentsService.GetAllTournaments(userInfo?.Id);
      return Ok(tourneys);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }


  [HttpPost]
  public ActionResult<Tournament> CreateTournament([FromBody] Tournament tourneyData)
  {
    try
    {
      Tournament tourney = _tournamentsService.CreateTournament(tourneyData);
      return Ok(tourney);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("{tourneyId}")]
  [Authorize]
  public async Task<ActionResult<string>> DeleteTournament(int tourneyId)
  {
    try
    {
      Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
      _tournamentsService.ArchiveTourney(tourneyId, userInfo?.Id);
      return Ok("Tournament deleted");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPut("{tournamentId}")]
  [Authorize]
  public async Task<ActionResult<Sponsor>> EditSponsor([FromBody] Tournament tourneyData, int tournamentId)
  {
    try
    {
      Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
      Tournament tourney = _tournamentsService.UpdateTourney(tourneyData, userInfo.Id);
      return Ok(tourney);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}
