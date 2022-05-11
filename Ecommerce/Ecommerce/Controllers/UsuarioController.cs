﻿using Ecommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string cpf, string senha)
        {
            Usuario u = Usuario.Entra(cpf, senha);
            if (u != null)
            {
                //guarda o usuario
                HttpContext.Session.SetString("user", JsonConvert.SerializeObject(u));
                //criar um cookie
                Response.Cookies.Append("obj", JsonConvert.SerializeObject(u));

                if (u.Tipo == "Adm")
                {
                    return View("Adm");
                }
                else
                {
                    return View("Cliente");
                }
            }
            else
            {
                return RedirectToAction("Cadastro");
            }


        }

        //alterar a parte de cadastro
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(string nome, string cpf, string senha)
        {
            Usuario u = new Usuario(nome, null, null, cpf, senha, null);
            ViewBag["msg"] = u.Cadastro(nome, cpf, senha);

            //retorna a view login após fazer o cadastro
            return View("Login");
        }

    }
}


