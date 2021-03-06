﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using curso.api.Models.Usuarios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace curso.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput) 
        {
            return Ok(loginViewModelInput);
        }

        [HttpPost]
        [Route("Registrar")]
        public IActionResult Registrar(RegistroViewModelInput loginViewModelInput)

        {
            return Created("", loginViewModelInput);
        }
    }
}
