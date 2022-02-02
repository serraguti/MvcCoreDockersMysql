using Microsoft.AspNetCore.Mvc;
using MvcCoreDockersMysql.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreDockersMysql.Controllers
{
    public class DepartamentosController : Controller
    {
        private RepositoryDepartamentos repo;

        public DepartamentosController(RepositoryDepartamentos repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View(this.repo.GetDepartamentos());
        }

        public IActionResult Details(int id)
        {
            return View(this.repo.FindDepartamento(id));
        }
    }
}
