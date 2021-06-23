using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebServiceApp.Models;

namespace WebServiceApp.DTO
{
    public class PacienteDTO
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