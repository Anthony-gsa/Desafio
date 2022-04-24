using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Desafio.Models;

namespace Desafio.Data
{
    public class DesafioContext : DbContext
    {
        public DesafioContext (DbContextOptions<DesafioContext> options)
            : base(options)
        {
        }

        public DbSet<Desafio.Models.Imovel> Imovel { get; set; }
    }
}
