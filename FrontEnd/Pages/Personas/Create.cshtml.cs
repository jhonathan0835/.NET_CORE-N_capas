﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dominio;
using Persistencia;

namespace FrontEnd.Pages.Personas
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioPersona _repo;

        public Empleado Persona { get; set; }

        public CreateModel(IRepositorioPersona repositorioPersona)
        {
            _repo = repositorioPersona;
        }
        public void OnGet()
        {
        }

        public void OnPost(Empleado persona)
        {
            _repo.Add(persona);
        }

        public void Prueba(int id)
        {
            Console.WriteLine("Hola");
        }
    }
}
