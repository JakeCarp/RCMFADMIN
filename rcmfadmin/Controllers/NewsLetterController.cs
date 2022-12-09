namespace rcmfadmin.Controllers;

[ApiController]
[Route("[controller]")]
public class NewsLetterController : ControllerBase
{
  private readonly NewsletterService _newsLetterService;
  private readonly Auth0Provider _auth0Provider;

  public NewsLetterController(NewsletterService newsLetterService, Auth0Provider auth0Provider)
  {
    _newsLetterService = newsLetterService;
    _auth0Provider = auth0Provider;
  }

  [Authorize]
  [HttpPost]
  public ActionResult<NewsLetter> CreateNewsletter([FromBody] NewsLetter newsLetterData)
  {
    try
    {

      NewsLetter newsLetter = _newsLetterService.CreateNewsletter(newsLetterData);
      return Ok(newsLetter);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet]
  public async Task<ActionResult<List<NewsLetter>>> GetAllNewsLetters()
  {
    try
    {
      Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);

      List<NewsLetter> newsLetters = _newsLetterService.GetAllNewsLetters(userInfo?.Id);
      return Ok(newsLetters);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }


  [HttpDelete("{newsLetterId}")]
  [Authorize]
  public async Task<ActionResult<string>> DeleteNewsLetter(int newsLetterId)
  {
    try
    {
      Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
      _newsLetterService.DeleteNewsLetter(newsLetterId, userInfo?.Id);
      return Ok("NewsLetter deleted");
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }





}
