using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebServiceApp.Models
{
    public partial class Ring
    {
        public int Id { get; set; }
        public double? Area { get; set; }
        public double? Radius { get; set; }
        public double? Perimeter { get; set; }
    }
}
