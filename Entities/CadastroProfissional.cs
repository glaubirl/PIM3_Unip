namespace Sistema.Entities
{
    public class CadastroProfissional : Cadastro
    {
        public string Cargo;
        public double Salario;

        public CadastroProfissional(){

        }

        public CadastroProfissional(string Nome, string Cpf, string Endereco, string Cargo, double Salario)
        : base(Nome, Cpf, Endereco){
            this.Cargo = Cargo;
            this.Salario = Salario;
        }

        public override string DadosCadastro(){
            base.DadosCadastro();
            string texto = base.DadosCadastro() + "\nCargo: " + Cargo + "\nSalario: " + Salario;
            return texto;
        }

    }
}