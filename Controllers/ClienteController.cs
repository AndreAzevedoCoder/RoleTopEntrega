using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopOFC.ViewModel;
using RoleTopOficial.Models;
using RoleTopOficial.Repositories;
using RoleTopOficial.ViewModel;

namespace RoleTopOficial.Controllers
{
    public class ClienteController : AbstractController
    {
        EventoRepository eventorepository = new EventoRepository();
        ClienteRepository clienterepository = new ClienteRepository();
        
        public IActionResult Index()
        {

            switch(ObterUsuarioNomeSession())
            {
                case "Administrador":
                    return RedirectToAction("Dashboard","Administrador");
                case "":
                    return RedirectToAction("index","Home");
                default:
                    ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession());
                    clienteviewmodel.Eventos = eventorepository.ObterEventosCliente(ObterUsuarioNomeSession());
                    return View(clienteviewmodel);
            }

        }
        public IActionResult QuemSomos()
        {
            ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession());
            return View(clienteviewmodel);
        }
        public IActionResult Galeria()
        {
            ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession());
            return View(clienteviewmodel);
        }
        public IActionResult Contato()
        {
            ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession());
            return View(clienteviewmodel);
        }
        static string ComputeSha256Hash(string rawData)  
        {  
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())  
            {  
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));  
  
                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();  
                for (int i = 0; i < bytes.Length; i++)  
                {  
                    builder.Append(bytes[i].ToString("x2"));  
                }  
                return builder.ToString();  
            }  
        }
        public IActionResult CriarEvento()
        {
            switch(ObterUsuarioNomeSession())
            {
                case "Administrador":
                    return RedirectToAction("Dashboard","Administrador");
                case "":
                    return RedirectToAction("index","Home");
                default:
                    ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession());
                    return View(clienteviewmodel);
            }


        }
        public IActionResult Logoff()
        {
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            return RedirectToAction("index","Home");
        }


        public IActionResult Configuracoes()
        {

            ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession());
            return View(clienteviewmodel);

        }
        [HttpPost]
        public IActionResult NovaSenha(IFormCollection form)
        {
            
            Cliente cliente = clienterepository.ObterPor(ObterUsuarioNomeSession());
            if(cliente.Senha == ComputeSha256Hash(form["SenhaAtual"]))
            {
                if(form["NovaSenha"] == form["RepetirNovaSenha"])
                {
                    string Senha = ComputeSha256Hash(form["NovaSenha"]);
                    clienterepository.TrocarSenha(cliente.Usuario,Senha);
                    
                    return RedirectToAction("index","Cliente");
                }else{
                    ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession(),"Senha e Repetir senha não são iguais");
                    return View("Configuracoes",clienteviewmodel);
                }
            }else{
                ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession(),"Senha incorreta");
                return View("Configuracoes",clienteviewmodel);
            }

        }
        [HttpPost]
        public IActionResult Remover(IFormCollection form)
        {
            eventorepository.Remover( form["ID"] );
            return RedirectToAction("index","Cliente");
        }

        [HttpPost]
        public IActionResult CriarEvento(IFormCollection form)
        {
                Evento evento = new Evento(
                    form["NomeDoEvento"],
                    DateTime.Parse(form["DataDoEvento"]),
                    form["Pacote"],
                    int.Parse(form["QuantidadeDePessoas"])
                );
                evento.DonoDoEvento = ObterUsuarioNomeSession();
                eventorepository.Inserir(evento);
                
                return RedirectToAction("index","Cliente");
                
            


        }

    }
}
