using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketAppV1.Areas.Users.Models
{
    public class InputModelRegister
    {
        [Required(ErrorMessage = "El nombre es necesario")]
        public string Name { get; set; }
        [Required(ErrorMessage = "El apellido es necesario")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "El documento de identificación es necesario")]
        public string DocId { get; set; }
        [Required(ErrorMessage = "El número de teléfono es necesario")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2})\)?[-. ]?([0-9]{2})[-. ]?([0-9]{5})$", ErrorMessage = "Formato de teléfono no válido")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "El correo electrónico es obligatorio")]
        [EmailAddress(ErrorMessage = "Correo electrónico no válido")]
        public string Email { get; set; }
        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "La contraseña es necesaria")]
        [StringLength(20, ErrorMessage = "La cantidad de caracteres de {0} debe ser de al menos {2}", MinimumLength = 8)]
        public string Password { get; set; }
        
    }   
}
