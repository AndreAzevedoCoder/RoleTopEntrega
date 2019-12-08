using System;
using System.IO;
using RoleTopOficial.Models;

namespace RoleTopOficial.Repositories
{
    public class ClienteRepository
    {
        
        public const string PATH = "Database/Cliente.csv";

        public ClienteRepository(){
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }

        }

        public bool Inserir(Cliente cliente)
        {
            var linha = new string[]{PrepararRegistroCSV(cliente)};
            File.AppendAllLines(PATH, linha);
            return true;
        }
        public void TrocarSenha(string Usuario, string NovaSenha)
        {
            string[] linhas = File.ReadAllLines(PATH);
            Cliente c = new Cliente();
            for(int i = 0; i < linhas.Length; i++){
                if(ExtrairValorDoCampo("Usuario",linhas[i]) == Usuario){
                    
                    c.Nome = ExtrairValorDoCampo("Nome",linhas[i]);
                    c.Usuario = ExtrairValorDoCampo("Usuario",linhas[i]);
                    c.Senha = NovaSenha;
                    c.Email = ExtrairValorDoCampo("Email",linhas[i]);
                    c.DataDeNascimento = DateTime.Parse(ExtrairValorDoCampo("DataDeNascimento",linhas[i]));
                    linhas[i] = PrepararRegistroCSV(c);
                   
                }
            }
            File.WriteAllLines(PATH, linhas);
            
            
            
 
        }

        public Cliente ObterPor( string Usuario )
        {
            var linhas = File.ReadAllLines(PATH);
            foreach(var linha in linhas){
                if(ExtrairValorDoCampo("Usuario",linha) == Usuario){
                    Cliente c = new Cliente();
                    c.Nome = ExtrairValorDoCampo("Nome",linha);
                    c.Usuario = ExtrairValorDoCampo("Usuario",linha);
                    c.Senha = ExtrairValorDoCampo("Senha",linha);
                    c.Email = ExtrairValorDoCampo("Email",linha);
                    c.DataDeNascimento = DateTime.Parse(ExtrairValorDoCampo("DataDeNascimento",linha));
                    return c;
                }
            }
            return null;
        }
        public string ExtrairValorDoCampo( string nomeCampo, string linha )
        {
            var chave = nomeCampo;
            var indiceChave = linha.IndexOf(chave);
            var indiceTerminal = linha.IndexOf(";",indiceChave);
            var valor = "";

            if(indiceTerminal != -1){
                valor = linha.Substring(indiceChave, indiceTerminal - indiceChave);
            }else{
                valor = linha.Substring(indiceChave);
            }
            return valor.Replace(nomeCampo + "=","");
        }

        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"Nome={cliente.Nome};Usuario={cliente.Usuario};Senha={cliente.Senha};Email={cliente.Email};DataDeNascimento={cliente.DataDeNascimento}";
        }





    }
}