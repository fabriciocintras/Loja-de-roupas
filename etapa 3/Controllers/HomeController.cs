using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using etapa_3.Models;

namespace etapa_3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult FaleConosco()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FaleConosco(Cliente novoCliente)
        {
            BaseDados bd = new BaseDados();
            bd.InserirForm(novoCliente);
            return View("Concluido");
        }
        
        public IActionResult ListagemFormulario()
        {
            if(HttpContext.Session.GetInt32("idUsuario") == null)
                return RedirectToAction("Login", "Usuario");
            BaseDados bd = new BaseDados();
            List<Cliente> cliente = bd.Buscar();
            return View(cliente);
           /* List<Cliente> cliente = BaseDados.Listar();
            return View(cliente);*/
        }
        public IActionResult Produtos()
        {
            return View();
        }


        public IActionResult produtoDetalheQuik()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult produtoDetalheQuik(itemPedido novoCliente)
        {
            @ViewBag.Descricao = novoCliente.Descricao="camisa quiksilver basica";
            @ViewBag.Valor = novoCliente.Valor=49.99;
            Pedido.Incluir(novoCliente);
            return View("ItemAdicionadoAoCarrinho","Home");
        }

        public IActionResult produtoDetalheAdidas()
        {  
            return View();
        }
        [HttpPost]
        public IActionResult produtoDetalheAdidas(itemPedido novoCliente)
        {
            @ViewBag.Descricao = novoCliente.Descricao="camisa adidas basica";
            @ViewBag.Valor = novoCliente.Valor=49.99;
            Pedido.Incluir(novoCliente);
            return View("ItemAdicionadoAoCarrinho","Home");
        }

        public IActionResult produtoDetalheNike()
        {
            return View();
        }
        [HttpPost]
        public IActionResult produtoDetalheNike(itemPedido novoCliente)
        {
            @ViewBag.Descricao = novoCliente.Descricao="camisa nike basica";
            @ViewBag.Valor = novoCliente.Valor=49.99;
            Pedido.Incluir(novoCliente);
            return View("ItemAdicionadoAoCarrinho","Home");
        }
        public IActionResult camisaDetalheOakley()
        {

            return View();
        }
        [HttpPost]
        public IActionResult camisaDetalheOakley(itemPedido novoCliente)
        {
            @ViewBag.Descricao = novoCliente.Descricao="camisa oakley basica";
            @ViewBag.Valor = novoCliente.Valor=49.99;
            Pedido.Incluir(novoCliente);
            
            return View("ItemAdicionadoAoCarrinho","Home");
        }
        
        public IActionResult carrinho()
        {
            List<itemPedido> itens = Pedido.ListarPedido();
            ViewBag.total = Pedido.Total();
            return View(itens);
        }
    }
}
