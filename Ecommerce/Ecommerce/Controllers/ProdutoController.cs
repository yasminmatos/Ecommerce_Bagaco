﻿using Ecommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult CadastroProduto()
        {
            //retorna para a view principal do Adm
            return View();
        }

        [HttpPost]
        public IActionResult CadastroProduto(string nome, double preco, string descricao, int codigo, int qtd)
        {
            foreach (IFormFile arquivo in Request.Form.Files)
            {
                string tipoArquivo = arquivo.ContentType;
                if (tipoArquivo.Contains("png") ||
                        tipoArquivo.Contains("jpeg"))
                {
                    MemoryStream s = new MemoryStream();
                    arquivo.CopyToAsync(s);
                    byte[] bytesArquivo = s.ToArray();
                    Produto p = new Produto(nome, preco, descricao, codigo, qtd, bytesArquivo);

                    TempData["msg"] = p.Cadastro();
                }
            }
            return RedirectToAction("CadastroProduto");
        }

        public IActionResult Carrinho()
        {
            return View(Produto.MostrarCarrinho());
        }

        public IActionResult AddCarrinho(int codigo)
        {

            Produto p = new Produto("", 0, "", codigo, 0, null);

            //adiciona o produto na tela carrinho
            TempData["msg"] = p.AddCarrinho();

            //adiciona o produto na tabela pedido
            TempData["msg"] = p.AddPedido(codigo);

            return RedirectToAction("ProdutosCliente");
        }

        [HttpGet]
        public IActionResult AtualizarDados(int comprados)
        {
            return View("Carrinho");
        }

        //método que vai salvar na tabela Pedidos
        public IActionResult Salvar()
        {
            return View("ProdutosCliente");
        }

        [HttpPost]
        public IActionResult Salvar(int quantidade)
        {
            Produto p = new Produto(null, 0, null, 0, quantidade, null);
            TempData["msg"] = p.SalvarPedido(quantidade);

            return RedirectToAction("ProdutosCliente");
        }

        public IActionResult ProdutosAdm()
        {

            return View(Produto.Listar());
        }

        public IActionResult ProdutosCliente()
        {
            return View(Produto.Listar());
        }
        public IActionResult AlterarProduto(int codigo)
        {
            ViewData["dados"] = Produto.RetornarDados(codigo);

            return View();

        }
        [HttpPost]
        public IActionResult AlterarProduto(string nome, double preco, string descricao, int codigo, int qtd)
        {
            foreach (IFormFile arquivo in Request.Form.Files)
            {
                string tipoArquivo = arquivo.ContentType;
                if (tipoArquivo.Contains("png") ||
                        tipoArquivo.Contains("jpeg"))
                {
                    MemoryStream s = new MemoryStream();
                    arquivo.CopyToAsync(s);
                    byte[] bytesArquivo = s.ToArray();
                    Produto p = new Produto(nome, preco, descricao, codigo, qtd, bytesArquivo);

                    TempData["msg"] = p.AlterarProduto(codigo);
                }
            }

            return RedirectToAction("AlterarProduto");
        }

        //exclui um produto (Adm)
        public IActionResult Excluir(int codigo)
        {
            Produto p = new Produto(null, 0, null, codigo, 0, null);
            TempData["msg"] = p.Excluir();
            return View("ProdutosAdm");
        }

    }

} 

    

