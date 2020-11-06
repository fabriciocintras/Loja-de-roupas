using System.Collections.Generic;
using etapa_3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace etapa_3.Controllers
{
    public class UsuarioController : Controller
    {
        
        public IActionResult Cadastro()
        {
            if(HttpContext.Session.GetInt32("idUsuario")== null || HttpContext.Session.GetInt32("TipoUsuario") != 0 )
                return RedirectToAction("Login","Usuario");
            return View();
        }
         public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(Usuario novoUsuario)
        {
           
            UsuarioBanco user = new UsuarioBanco();
            user.Insert(novoUsuario);
            ViewBag.Mensagem = "Cadastro concluido com sucesso";
            return View();
        }
        public IActionResult Lista()
        {
            if(HttpContext.Session.GetInt32("idUsuario")== null)
                return RedirectToAction("Login","Usuario");

            UsuarioBanco user = new UsuarioBanco();
            List<Usuario> lista = user.Query();
            return View(lista);
        }
       
        [HttpPost]
        public IActionResult Login(Usuario usuario)
        {
            UsuarioBanco usuarioBanco = new UsuarioBanco();
            Usuario usuarioSessao = usuarioBanco.QueryLogin(usuario);

            if(usuarioSessao != null)
            {
                ViewBag.Mensagem = "Voce esta logado!";
                HttpContext.Session.SetInt32("idUsuario", usuarioSessao.Id);
                HttpContext.Session.SetString("nomeUsuario", usuarioSessao.Nome);
                HttpContext.Session.SetInt32("TipoUsuario", usuarioSessao.Tipo);
                return RedirectToAction("Index","Home");
            }else
            {
                ViewBag.Mensagem = " Falha no login";
                return View();
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }
        
    }
}