using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelSA.Models
{
    public class hosa_usuarios
    {
        public int idUsuario { get; set; }
        [StringLength(25)]
        public string nombre { get; set; }
        [StringLength(50)]
        public string correo { get; set; }
        [StringLength(25)]
        public string alias { get; set; }
        [StringLength(50)]
        public string contra { get; set; }

    }
}
