using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _02_MVC_Servicios.Models
{
    public class PersonaModel
    {
        public String Nombre { get; set; }
        public string Apellidos { get; set; }
        public int idPersona { get; set; }
        public int idDireccion { get; set; }
        public DireccionModel DireccionPersona { get; set; }
        

        //Externas al modelo
        public String NombreCompleto { get; set; }
    }
}