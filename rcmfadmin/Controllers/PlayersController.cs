namespace rcmfadmin.Controllers;

[ApiController]
[Route("[controller]")]
public class PlayersController : ControllerBase
{
  private readonly Auth0Provider _auth0Provider;
  private readonly PlayersService _playersService;

  public PlayersController(Auth0Provider auth0Provider, PlayersService playersService)
  {
    _auth0Provider = auth0Provider;
    _playersService = playersService;
  }

  [HttpPost]
  public ActionResult<Player> CreatePlayer([FromBody] Player playerData)
  {
    try
    {
      Player player = _playersService.CreatePlayer(playerData);
      return Ok(player);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }







}
