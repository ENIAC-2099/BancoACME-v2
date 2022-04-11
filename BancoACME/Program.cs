using System;

namespace BancoACME
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrenteBob = new ContaCorrente("12345-6", "Bob Nelson");
            contaCorrenteBob.DepositarValor(50000);
            Console.WriteLine(contaCorrenteBob.SacarValor(10));
            Console.WriteLine(contaCorrenteBob.TransferirValor(50));
            Console.ReadLine();

            ContaPoupanca contaPoupancaTestolfo = new ContaPoupanca("71717-1", "Testolfo Rocha");
            contaPoupancaTestolfo.DepositarValor(15000);
            Console.WriteLine(contaPoupancaTestolfo.SacarValor(60));
            Console.WriteLine(contaPoupancaTestolfo.TransferirValor(30));
            Console.ReadLine();

            ContaCorrente contaCorrenteLisa = new ContaCorrente("65432-1", "Lisa Leite");
            contaCorrenteLisa.DepositarValor(60000);
            Console.WriteLine(contaCorrenteLisa.SacarValor(30));
            Console.WriteLine(contaCorrenteLisa.TransferirValor(50));
            Console.ReadLine();
        }
    }
}
