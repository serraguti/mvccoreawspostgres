﻿using Microsoft.AspNetCore.Mvc;
using MvcCoreAWSPostgres.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreAWSPostgres.Controllers
{
    public class DepartamentosController : Controller
    {
        RepositoryDepartamentos repo;

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
