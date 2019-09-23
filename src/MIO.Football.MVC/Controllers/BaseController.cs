using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MIO.Football.MVC.Controllers
{
    public class BaseController : Controller
    {
        protected string IdCampeonato = "";
        public BaseController() { }
        protected void SessionValid()
        {
            IdCampeonato = HttpContext.Session.GetString("IdCampeonato");
        }
        protected IActionResult ReturnView(string nome, object model = null)
        {
            if (string.IsNullOrWhiteSpace(IdCampeonato))
                return Redirect("~/Home/SessionTimeout");
            else
            {
                if (model != null)
                    return View(nome, model);
                else
                    return View(nome);
            }
        }
    }
}