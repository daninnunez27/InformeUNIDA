using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class LoginRegistroApp
    {
        public int Id { get; set; }
        public string Susuario { get; set; }
        public string Pass { get; set; }
        public string Nombre { get; set; }
    }
}
