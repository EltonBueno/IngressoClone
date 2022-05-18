﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Models
{
    public class FilmeCategoria
    {
        public Filme FilmeId { get; set; }
        public Filme Filme { get; set; }
        public Categoria CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
