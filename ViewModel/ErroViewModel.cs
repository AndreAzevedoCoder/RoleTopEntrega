namespace RoleTopOFC.ViewModel
{
    public class ErroViewModel
    {
        public string MensagemDeErro {get;set;}
        public ErroViewModel(string _MensagemDeErro)
        {
            this.MensagemDeErro = _MensagemDeErro;
        }
    }
}