using MadLib.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]

    public ActionResult Choose () { return View();}

    [Route("/result-zoo")]
    public ActionResult ResultZoo(string adj1, string adj2, string adj3, string adj4, string adj5, string verb1, string verb2, string verb3, string noun1, string noun2, string noun3, string adverb1) 
    {
      Story userStory = new Story();
      userStory.Noun1 = noun1;
      userStory.Noun2 = noun2;
      userStory.Noun3 = noun3;
      userStory.Adjective1 = adj1;
      userStory.Adjective2 = adj2;
      userStory.Adjective3 = adj3;
      userStory.Adjective4 = adj4;
      userStory.Adjective5 = adj5;
      userStory.Verb1 = verb1;
      userStory.Verb2 = verb2;
      userStory.Verb3 = verb3;
      userStory.Adverb1 = adverb1;
      return View(userStory);
    }

    [Route("/result-aliens")]
    public ActionResult ResultAliens(string noun, string adjective, string verb) 
    {
      Story userStory = new Story();
      userStory.Noun1 = noun1;
      userStory.Noun2 = noun2;
      userStory.Noun3 = noun3;
      userStory.Adjective1 = adj1;
      userStory.Adjective2 = adj2;
      userStory.Adjective3 = adj3;
      userStory.Adjective4 = adj4;
      userStory.Adjective5 = adj5;
      userStory.Verb1 = verb1;
      userStory.Verb2 = verb2;
      userStory.Verb3 = verb3;
      userStory.Adverb1 = adverb1;
      return View(userStory);
    }

    [Route("/form-zoo")]

    public ActionResult FormZoo () { return View();}

    [Route("/form-aliens")]

    public ActionResult FormAliens () { return View();}

  }
}