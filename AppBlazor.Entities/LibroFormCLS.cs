using System.ComponentModel.DataAnnotations;

namespace AppBlazor.Entities
{
    public class LibroFormCLS
    {
        [Required(ErrorMessage = "El ID del libro es requerido hija")]
        [Range(1, int.MaxValue,ErrorMessage ="el id debe ser un numero positivo")]
        public int  idlibro {  get; set; }
        [Required (ErrorMessage = "el titulo es requerido")]
        [MaxLength (100,ErrorMessage ="la logitud maxim del titulo son 100 caracteres")]
        public string titulo { get; set; } = null;
        [Required(ErrorMessage = "el resumen es requerido")]
        [MinLength(20, ErrorMessage = "la logitud minima del resumen son 20 caracteres")]

        public string resumen { get; set; } = null;
    }
}
