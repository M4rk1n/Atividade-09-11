using System;

namespace ATIVIDADE
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.nome = "Marcos";
            cliente.cpf = "123.123.123-20";
            cliente.Rua = "Joao das Neves";
            cliente.numero = 80;
            cliente.Bairro = "Novo-lar";

            //setei o nome da cidade pela classe endereço
            cliente.Cidade = "Bebedouro";
          


            cliente.Cep = "14705-240";
            cliente.EstadoNome = "São Paulo";
            cliente.EstadoSigla = "SP";






            Console.WriteLine("Nome:" + cliente.nome);
            Console.WriteLine("CPF:" + cliente.cpf);
            Console.WriteLine("RUA:" + cliente.Rua);
            Console.WriteLine("NÚMERO:" + cliente.numero);
            Console.WriteLine("BAIRRO:" + cliente.Bairro);
            Console.WriteLine("CIDADE:" + cliente.Cidade);
            Console.WriteLine("CEP:" + cliente.Cep);
            Console.WriteLine("NOME DO ESTADO:" + cliente.EstadoNome);
            Console.WriteLine("SIGLA:" + cliente.EstadoSigla);
        }

    }
}
