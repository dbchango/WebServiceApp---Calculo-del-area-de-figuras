using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceApp.DTO
{
    public class SquareDTO
    {
        public int Id { get; set; }
        public double? Base { get; set; }
        public double? Height { get; set; }
        public double? Width { get; set; }
    }
}