using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopOficial.Models;
using RoleTopOficial.Repositories;
using RoleTopOficial.ViewModel;

namespace RoleTopOficial.Controllers
{
    public class CadastroController : AbstractController
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index()
        {


            switch(ObterUsuarioNomeSession())
            {
                case "":
                    ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession());
                    return View(clienteviewmodel);
                default:
                    return RedirectToAction("index","Home");
            }


            
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
        public IActionResult Login()
        {

            switch(ObterUsuarioNomeSession())
            {
                case "":
                    ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession());
                    return View(clienteviewmodel);
                default:
                    return RedirectToAction("index","Home");
            }

        }

        [HttpPost]
        public IActionResult Logar(IFormCollection form)
        {
            if(form["Usuario"] != "")
            {
                Cliente cliente = clienteRepository.ObterPor(form["Usuario"]);
                if(cliente != null)
                {
                    if(ComputeSha256Hash(form["Senha"]) == cliente.Senha)
                    {
                        HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Usuario);
                        return RedirectToAction("index","Cliente");
                    }else
                    {
                        ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession(),"Senha incorreta");
                        return View("Login",clienteviewmodel);
                    }
                }else
                {
                    ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession(),"Usuario não existe");
                    return View("Login",clienteviewmodel); 
                }
            }else
            {
                ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession(),"Campo de usuario vazio");
                return View("Login",clienteviewmodel);
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form)
        {
            try
            {
                if(form["Usuario"] != "")
                {

                    if( form["Senha"] == form["RepetirSenha"] )
                    {

                        Cliente cliente = new Cliente(form["Nome"],
                            form["Usuario"],
                            ComputeSha256Hash(form["Senha"]),
                            form["email"],
                            DateTime.Parse(form["Data_Nascimento"])
                        );
                        clienteRepository.Inserir(cliente);
                        HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Usuario);
                        return RedirectToAction("index","Cliente");
                    }

                }


            }catch(Exception e)
            {
                return View();
            }




            return View("Fracasso");

        }

    }
}
