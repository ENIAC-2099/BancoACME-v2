using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoACME
{
    class ContaCorrente:Conta
    {
        const double tarifaSaque = 0.37/ 100;
        const double tarifaTransf = 0.10 / 100;
        public ContaCorrente(string idConta, string nomeCorrentista) : base(idConta, nomeCorrentista)
        {

        }

        public override string SacarValor(double valor)
        {
            double valorTarifa = valor * tarifaSaque;
            if (SaldoAtual - valor - valorTarifa < 0)
            {
                return "Operação não realizada. SALDO INSUFICIENTE";
            }
            saldoAtual = SaldoAtual - valor;
            return "Operação realizada com Sucesso";
        }

        public void DepositarValor(double valor)
        {
            saldoAtual = saldoAtual + valor;
        }

        public virtual string TransferirValor(double valor)
        {
            double valorTarifa = valor * tarifaTransf;
            if (SaldoAtual - valor - valorTarifa < 0)
            {
                return "Operação não realizada. SALDO INSUFICIENTE";
            }

            saldoAtual = SaldoAtual - valor;
            return "Transferencia realizada com Sucesso";
        }


    }
}
