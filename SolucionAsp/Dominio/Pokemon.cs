﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pokemon
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public string urlImagen { get; set; }

        public Tipo Tipo { get; set; }

        public Debilidad Debilidad { get; set;}
    }
}
