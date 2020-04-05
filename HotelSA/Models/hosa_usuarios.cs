using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelSA.Models
{
    public class hosa_usuarios
    {
        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string alias { get; set; }
        public string contra { get; set; }
    }
}
