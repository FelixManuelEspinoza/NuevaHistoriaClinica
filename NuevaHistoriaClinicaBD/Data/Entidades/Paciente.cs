using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevaHistoriaClinicaBD.Data.Entidades
{
    class Paciente
    {

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(30, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string NombreCompleto { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(8, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string DNI { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [MaxLength(8, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public int Edad { get; set; }


        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public string Localidad { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage = "Este dato no puede superar los {1} caracteres")]
        public int Telefono { get; set; }



    }

}

