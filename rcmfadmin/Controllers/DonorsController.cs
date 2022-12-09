namespace rcmfadmin.Controllers;

[ApiController]
[Route("[controller]")]
public class DonorsController : ControllerBase
{
  private readonly Auth0Provider _auth0Provider;
  private readonly DonorsService _donorsService;

  public DonorsController(Auth0Provider auth0Provider, DonorsService donorsService)
  {
    _auth0Provider = auth0Provider;
    _donorsService = donorsService;
  }

  [HttpPost]
  public ActionResult<Donor> CreateDonor([FromBody] Donor DonorData)
  {
    try
    {
      Donor Donor = _donorsService.CreateDonor(DonorData);
      return Ok(Donor);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("{donorId}")]
  [Authorize]
  public async Task<ActionResult<string>> DeleteDonor(int donorId)
  {
    try
    {
      Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
      _donorsService.DeleteDonor(donorId, userInfo?.Id);
      return Ok("Donor deleted");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet]
  [Authorize]
  public async Task<ActionResult<List<Donor>>> GetAllDonors()
  {
    try
    {
      Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);

      List<Donor> donors = _donorsService.GetAllDonors(userInfo?.Id);
      return Ok(donors);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }


  [HttpPut("{donorId}")]
  [Authorize]
  public async Task<ActionResult<Donor>> EditDonor([FromBody] Donor donorData)
  {
    try
    {
      Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
      Donor donor = _donorsService.EditDonor(donorData, userInfo?.Id);
      return Ok(donor);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }






}
