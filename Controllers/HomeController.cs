using Microsoft.AspNetCore.Mvc;
using PortafolioMVC.Models;

namespace PortafolioMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();

    public IActionResult Projects() => View();

    public IActionResult Contact() => View(new ContactViewModel());

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Contact(ContactViewModel model)
    {
        if (!ModelState.IsValid)
            return View(model);

        // Demo local: no envía correos ni almacena datos.
        ViewBag.Success = "¡Gracias! Tu mensaje fue validado correctamente. Configura un servicio de correo para recibirlo.";
        ModelState.Clear();
        return View(new ContactViewModel());
    }

    public IActionResult Error() => View();
}
