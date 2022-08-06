using System;

namespace Poo_cs1
{
    class Program
    {
        static void Main(string[] args)
        {
            AnalistaTI analistaTI = new AnalistaTI();

            analistaTI.Nome = "Denio Gonçalves";
            analistaTI.SalarioPadrao(3000);

            analistaTI.Reajustar();

            Console.WriteLine("Seu nome é "+analistaTI.Nome + " e seu salario com o aumento é "+ analistaTI.Salario);


            /*ContaPoupança contaPoupança = new ContaPoupança(123,500);
            contaPoupança.Depositar(200);
            contaPoupança.Sacar(100);
            double saldoPoupanca = contaPoupança.ConsultaSaldoDisponivel();

            Console.WriteLine("Saldo da conta poupança é "+ saldoPoupanca);

            ContaCorrente contaCorrente = new ContaCorrente(123, 1000);
            contaCorrente.Depositar(1000);
            contaCorrente.Sacar(500);

            double saldoCorrente = contaCorrente.ConsultaSaldoDisponivel();

            Console.WriteLine("Saldo da conta corrente é " + saldoCorrente);*/


            /*Trabalhando com Classes abstradas e Polimorfismo

            AnalistaTI analistaTI = new AnalistaTI();
            Gerente gerente = new Gerente();
            GerenteAgencia gerenteAgencia = new GerenteAgencia();
            GerenteAnalistaTI gerenteAnalistaTI = new GerenteAnalistaTI();


            analistaTI.Nome = "Denio Gonçalves";
            analistaTI.Salario = 3000;

            Console.WriteLine("O salario de " + analistaTI.Nome + " é " + analistaTI.Salario + " R$");

            analistaTI.Reajustar();
            Console.WriteLine("O salario de " + analistaTI.Nome + " teve um aumento, pq ele é bom de serviço. Agora é " + analistaTI.Salario + " R$");


            Console.WriteLine("-------------------------------------------------------------------");

            gerente.Nome = "Jadir Andrade";
            gerente.Salario = 6000;

            Console.WriteLine("O salario de " + gerente.Nome + " é " + gerente.Salario + "R$");

            gerente.Reajustar();
            Console.WriteLine("O salario de " + gerente.Nome + " teve um aumento, pq ele esta aposentando. Agora é " + gerente.Salario + " R$");


            Console.WriteLine("-------------------------------------------------------------------");

            gerenteAgencia.Nome = "Izolina Resende";
            gerenteAgencia.Salario = 9000 ;

            Console.WriteLine("O salario de " + gerenteAgencia.Nome + " é " + gerenteAgencia.Salario + "R$");

            gerenteAgencia.Reajustar();
            Console.WriteLine("O salario de " + gerenteAgencia.Nome + " teve um aumento, pq ela gosta de ajudar o Ronaldo gordão. Agora é " + gerenteAgencia.Salario + " R$");


            Console.WriteLine("-------------------------------------------------------------------");

            gerenteAnalistaTI.Nome = "Diego Gonçalves";
            gerenteAnalistaTI.Salario = 100000;

            Console.WriteLine("O salario de " + gerenteAnalistaTI.Nome + " é " + gerenteAnalistaTI.Salario + " R$");

            gerenteAnalistaTI.Reajustar();
            Console.WriteLine("O salario de " + gerenteAnalistaTI.Nome + " teve um aumento, pq ele é discípulo do Magela. Agora é " + gerenteAnalistaTI.Salario + " R$");


            Console.WriteLine("-------------------------------------------------------------------");*/



            /*trabalhando com herança
             * 
            ContaPoupança contaPoupança = new ContaPoupança(756, 500);
            contaPoupança.Depositar(100);
            contaPoupança.Sacar(10);

            double saldoTotal = contaPoupança.ConsultaSaldoDisponivel();

             contaPoupança.MostrarNumeroConta();

            Console.WriteLine("Saldo da conta poupança é "+ saldoTotal);

            Conta conta = new Conta(543, 200);
            conta.Depositar(500);
            conta.Sacar(300);

            double ContaCorrente = conta.ConsultaSaldoDisponivel();
            Console.WriteLine("Saldo da conta corrente é " + ContaCorrente); */

            /*Trabalahndo com metodos e atributos estaticos
            Conta conta1 = new Conta(123, 500);
            Conta conta2 = new Conta(234, 500);
            Conta conta3 = new Conta(456, 500);

            Console.WriteLine("O total de contas é "+ Conta.TotalContasCriasdas);

            int TotalContas = Conta.NovoTotalContasCriadas();

            Console.WriteLine("O proximo total de contas é " + TotalContas);*/


            /**Console.WriteLine("Qual seu nome?");
            string nome1 = Console.ReadLine();


            Conta conta1 = new Conta(123);
            Conta conta2 = new Conta(2424);

            conta1.Saldo = 1500;
            conta1.Limite = 500;
            conta1.Numero = 123;

            Console.WriteLine("Seu nome é " + nome1 + " vc é bonitão, porém é quebrado!" + "Seu saldo é " + conta1.Saldo + " R$");
            Console.WriteLine("Como vc é quebrado, seu limite é de " + conta1.Limite + " R$");
            Console.WriteLine("O numero da sua conta é conta é " + conta1.Numero);

            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();

            conta2.Saldo = 1000000000;
            conta2.Limite = 5000000;
            conta2.Numero = 2424;

            Console.WriteLine("Seu nome é " + nome + " vc é feio pra caralho!" + "seu saldo é " + conta2.Saldo + " R$");
            Console.WriteLine("Vc esta cheio do cobrão na poupança! Seu limite é de " + conta2.Limite + " R$");
            Console.WriteLine("O numero da sua conta é conta é " + conta2.Numero);

            tela();
        }
        static void tela()
        {
            Conta conta = new Conta(123);
            conta.AdicionarLimite(500);

            conta.Depositar(4500);
            conta.Depositar(2500);
            conta.Depositar(500);


            bool saca = conta.Sacar(2000);

            if (saca)
            {
                double saldo = conta.ConsultaSaldoDisponivel();

                Console.WriteLine("Seu limite é " + conta.Limite + "R$");
                Console.WriteLine("Seu saldo atual é " + saldo + "R$");
                Console.WriteLine("O numero da sua conta é "+ conta.Numero);
            }*/

            /*Criando um objeto de cada classe
            CartaoDeCredito cartao = new CartaoDeCredito();
            Cliente cliente = new Cliente();*/

            /*Adicionando o nome do cliente
            cliente.nome = "Denio Gonçalves"; */

            /*Adicionando o Numero e data de validade do cartão
            cartao.Numero = "7889644132130";
           cartao.DataDeValidade = "11/2057";
           cartao.Cliente = cliente;

           Console.WriteLine("O nome do cliente é "+ cliente.nome);
           Console.WriteLine("O numero do cartão é " + cartao.Numero);
           Console.WriteLine("A data de validade do cartão é "+ cartao.DataDeValidade);
           Console.WriteLine("O nome do cliene do agregado é "+ cartao.Cliente.nome);*/
        }



    }  
        
}
