﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext (DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<RegistroVendas> RegistroVendas { get; set; }

    }
}
