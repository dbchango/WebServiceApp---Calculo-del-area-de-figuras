using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebServiceApp.Models;

namespace WebServiceApp.DTO
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}