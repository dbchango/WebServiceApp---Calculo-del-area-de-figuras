using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceApp.DTO
{
    public class RingDTO
    {
        public int Id { get; set; }
        public double? Area { get; set; }
        public double? Radius { get; set; }
        public double? Perimeter { get; set; }
    }
}