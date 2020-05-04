namespace Sistema.Entities
{
    public class Cadastro
    {
        public string Nome;
        public string Cpf { get; private set; }
        public string Endereco;

        public Cadastro(){

        }

        public Cadastro(string Nome, string Cpf, string Endereco){
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Endereco = Cpf;
        }

        public virtual string DadosCadastro(){
            string texto = "Nome: " + Nome + "\nCPF: " + Cpf + "\nEndereço: " + Endereco;
            return texto;
        }

    }
}