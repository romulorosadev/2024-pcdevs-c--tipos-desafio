using System;

namespace tipos
{
    class ContaBancaria
    {
        //DECLARAR ATRIBUTOS CLASS

        //string
        public string Titular;
        //double para maior precisão nas casas decimais. Evitar dizima períodica.
        public double Saldo;


        //MÉTODO CONSTRUTOR CLASS CONTABANCARIA (argumentos)
        public ContaBancaria(string titular, double saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }



        // Criar função operação depositar
        public void Depositar(double valor)
        {
            //Acrescentar
            Saldo += valor;
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"DEPÓSITO realizado com sucesso!\nTITULAR: {Titular}\nOPERAÇÃO: Depósito\nVALOR: R${valor}");
        }

        // Criar função operação sacar
        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("SALDO INSUFICIENTE");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"SAQUE realizado com sucesso!\nTITULAR: {Titular}\nOPERAÇÃO: Saque\nVALOR: R${valor}");
            }

        }


        // Criar função operação exibir
        public void ExibirSaldo()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"TITULAR: {Titular} | SALDO ATUAL: R${Saldo}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Criar um conta bancaria para joao com saldo de 1000
            ContaBancaria contaJoao = new ContaBancaria("João", 1000);

            //Chamar funções para realizar as opoerações
            Console.WriteLine("OPERAÇÕES - CÓDIGO BASE");
            contaJoao.Depositar(500);
            contaJoao.Sacar(200);

            Console.WriteLine("\n\nSALDO - CÓDIGO BASE");
            contaJoao.ExibirSaldo();



            //DESAFIO
            // 1 - Criando uma nova conta bancária para Maria com saldo inicial de 2000
            ContaBancaria contaMaria = new ContaBancaria("Maria", 2000);

            // 2 -  Transferindo 300 da conta de Maria para a conta de João
            Console.WriteLine("\n\n\n\nOPERAÇÕES - DESAFIO");
            contaMaria.Sacar(300);
            contaJoao.Depositar(300);

            // 3 - Exibindo os saldos atualizados das contas
            Console.WriteLine("\n\nSALDOS - DESAFIO");
            contaMaria.ExibirSaldo();
            contaJoao.ExibirSaldo();
        }
    }
}
