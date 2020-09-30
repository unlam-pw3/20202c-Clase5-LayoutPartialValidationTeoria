using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LayoutValidation.Models
{
    public class Empleado
    {
        [Required(ErrorMessage = "Debe Ingresar un Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Edad es campo obligatorio")]
        [Range(1, 100, ErrorMessage = "La edad debe estar entre 1 y 100")]
        public int Edad { get; set; }

        [StringLength(100, ErrorMessage = "Hasta 100 caracteres")]
        [RegularExpression ("[a-zA-Z ]{2,254}", ErrorMessage ="Solo Caracteres")]
        public string Descripcion { get; set; }
        
        [Required(ErrorMessage = "El mail es requerido")]
        [EmailAddress(ErrorMessage = "El mail no es correcto")]
        [ExisteMailADM (ErrorMessage = "El Mail Existe")]
        public string Email { get; set; }

        [Required(ErrorMessage ="El Pass es requerido")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage ="La confirmacion no es correcta" )]
        public string ConfirmePassword { get; set; }

    }


    public class ExisteMailADM : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string mail = value.ToString();

            bool resultado;

            if (mail == "admin@misitio.com")
            {
                resultado = false;
            }
            else
            {
                resultado = true;
            }

            return resultado;
        }

    }
}