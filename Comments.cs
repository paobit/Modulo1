using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace repaso_1
{
    public class Comments:Usuario
    {
        public int ID { get; set; }
        public string Date { get; set; }
        public string Comment { get; set; }
        public Usuario Usuario{ get; set; }

    }
}