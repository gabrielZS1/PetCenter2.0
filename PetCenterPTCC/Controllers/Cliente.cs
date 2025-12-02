using Microsoft.AspNetCore.Mvc;

namespace PetCenterPTCC.Controllers
{
    public class Cliente : Controller
    {
        public IActionResult CadastroCliente()
        {
            return View();
        }

        public IActionResult LoginCliente()
        {
            return View();
        }
    }
}
