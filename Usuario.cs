using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace repaso_1
{
    public class Usuario
    {
        public int ID { get; set; }

        public string Nombre { get;set; }
        
        public string Passeword { get; set; }

        public string Email { get; set; }

        public string post { get; set; }

        public string Comments { get; set; }

    }

   
}