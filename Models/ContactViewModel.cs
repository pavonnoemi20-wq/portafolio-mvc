using System.ComponentModel.DataAnnotations;

namespace PortafolioMVC.Models;

public class ContactViewModel
{
    [Required(ErrorMessage = "Escribe tu nombre.")]
    [StringLength(70)]
    [Display(Name = "Nombre")]
    public string Name { get; set; } = "";

    [Required(ErrorMessage = "Escribe un correo válido.")]
    [EmailAddress(ErrorMessage = "El correo no tiene un formato válido.")]
    [Display(Name = "Correo electrónico")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "Escribe tu mensaje.")]
    [StringLength(1000, MinimumLength = 10, ErrorMessage = "El mensaje debe tener entre 10 y 1000 caracteres.")]
    [Display(Name = "Mensaje")]
    public string Message { get; set; } = "";
}
