//import
using Microsoft.AspNetCore.Mvc;
//namespace
namespace PortfolioI.Controllers;

public class IndexController : Controller
{
    //route to Index front page
    [HttpGet("")]
    //render-view
    public ViewResult Index()
    {
        return View();
    }
}   