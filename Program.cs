using System;
using Sistema.Entities;
using Entities.Enums;
using System.Globalization;

namespace Sistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro cadastro = new Cadastro();

            System.Console.WriteLine("===SISTEMA DE CADASTRO===\n");
            System.Console.Write("Tipo de cadastro: \n(a)profissional\n(b)paciente \nOpção: ");
            char op = char.Parse(Console.ReadLine());
            System.Console.Write("\nNome: ");
            string nome = Console.ReadLine();
            System.Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            System.Console.Write("Endereço: ");
            string endereco = Console.ReadLine();
            if(op == 'a'){
                System.Console.Write("Cargo: ");
                string cargo = Console.ReadLine();
                System.Console.Write("Salário: R$");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cadastro = new CadastroProfissional(nome, cpf, endereco, cargo, salario);
            }
            else if(op == 'b'){
                System.Console.Write("Condição do paciente (Assintomático, Suspeito, Confirmado): ");
                CondicoesPaciente condicao = Enum.Parse<CondicoesPaciente>(Console.ReadLine());
                cadastro = new CadastroPaciente(nome, cpf, endereco, condicao);
                System.Console.WriteLine(cadastro);
            }

            System.Console.WriteLine("\n=DADOS DO CADASTRO=\n" + cadastro.DadosCadastro());

            Console.ReadLine();
            System.Console.WriteLine("\n");
        }
        
    }
}
