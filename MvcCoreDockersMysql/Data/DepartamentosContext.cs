using Microsoft.EntityFrameworkCore;
using MvcCoreDockersMysql.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreDockersMysql.Data
{
    public class DepartamentosContext: DbContext
    {
        public DepartamentosContext(DbContextOptions<DepartamentosContext> options)
            : base(options) { }

        public DbSet<Departamento> Departamentos { get; set; }
    }
}
