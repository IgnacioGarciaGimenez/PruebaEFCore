﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Dominio.Receptora
{
    public class Receptora
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public EstadoReceptora Estado { get; set; }
        public ICollection<ModuloEntrada> ModulosEntrada { get; set; }      

    }
}
