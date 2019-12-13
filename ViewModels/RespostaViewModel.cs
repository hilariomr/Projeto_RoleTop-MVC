namespace RoleTopMVC_.ViewsModels {
    public class RespostaViewModel : BaseViewModel {
        public string Mensagem { get; set; }

        public RespostaViewModel () { }
        public RespostaViewModel (string mensagem) {
            this.NomeView = "resposta";
            this.Mensagem = mensagem;
        }
    }
}