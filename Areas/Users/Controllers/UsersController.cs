using Microsoft.AspNetCore.Mvc;

namespace MarketAppV1.Areas.Users.Controllers
{
    //Le especificamos al controlador en que área se encuentra ::: Alejo Restrepo 2:58 9 de Dic2021
    [Area("Users")]
    public class UsersController : Controller
    {
        //Agregamos vista Users.cshtml al método 
        public IActionResult Users()
        {
            return View();
        }
    }
}
