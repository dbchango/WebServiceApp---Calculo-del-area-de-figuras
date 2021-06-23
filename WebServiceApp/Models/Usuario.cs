using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebServiceApp.Models
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
