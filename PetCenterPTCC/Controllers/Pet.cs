using Microsoft.AspNetCore.Mvc;

namespace PetCenterPTCC.Controllers
{
    public class Pet : Controller
    {
        public IActionResult CadastrarPet()
        {
            return View();
        }
    }
}
