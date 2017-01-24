using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _02_MVC_Servicios.Models
{
    public class DireccionModel
    {
        public string Via { get; set; }
        public string NombreVia { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public int idDireccion { get; set; }
    }
}