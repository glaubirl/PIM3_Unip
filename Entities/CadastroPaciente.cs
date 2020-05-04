using Entities.Enums;

namespace Sistema.Entities
{
    public class CadastroPaciente : Cadastro
    {
        public CondicoesPaciente Condicoes;

        public CadastroPaciente(){

        }

        public CadastroPaciente(string Nome, string Cpf, string Endereco, CondicoesPaciente Condicoes)
        : base(Nome, Cpf, Endereco){
            this.Condicoes = Condicoes;
        }

        public override string DadosCadastro(){
            base.DadosCadastro();
            string texto = base.DadosCadastro() + "\nCondição do paciente: " + Condicoes;
            return texto;
        }

    }
}