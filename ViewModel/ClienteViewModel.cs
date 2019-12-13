using System.Collections.Generic;
using RoleTopOficial.ViewModel;
using RoleTopOficial.Models;

namespace RoleTopOficial.ViewModel
{
    public class ClienteViewModel 
    {
        public string Usuario {get;set;}
        public List<Evento> Eventos {get;set;}

        public string MensagemDeErro {get;set;}

        public ClienteViewModel( string usuario )
        {
            this.Eventos = new List<Evento>();
            this.Usuario = usuario;
            this.MensagemDeErro = "";
        }
        public ClienteViewModel( string usuario,string erro )
        {
            this.Eventos = new List<Evento>();
            this.Usuario = usuario;
            this.MensagemDeErro = erro;
        }
    }
}