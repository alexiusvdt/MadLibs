using MadLib.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {

    [Route("/result")]
    public ActionResult Result(string noun, string adjective, string verb) 
    {
      Story userStory = new Story();
      userStory.Noun = noun;
      userStory.Adjective = adjective;
      userStory.Verb = verb;
      return View(userStory);
    }

    [Route("/")]

    public ActionResult Form () { return View();}

  }
}