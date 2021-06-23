using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebServiceApp.Models
{
    public partial class Paciente
    {
        public int IdPaciente { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string Cedula { get; set; }
        public double? Altura { get; set; }
        public double? Edad { get; set; }
        public double? Peso { get; set; }
        public int? IdUsuario { get; set; }
    }
}
