using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoACME
{
    class Conta
    {
        private String idConta;
        private String nomeCorrentista;
        protected double saldoAtual;

        public Conta(string idConta, string nomeCorrentista)
        {
            this.idConta = idConta;
            this.nomeCorrentista = nomeCorrentista;
            this.saldoAtual = 0;
        }

        protected string IdConta
        {
            get
            {
                return idConta;
            }
        }

        protected string NomeCorrentista
        {
            get
            {
                return nomeCorrentista;
            }
        }

        protected double SaldoAtual
        {
            get
            {
                return saldoAtual;
            }
        }
        public virtual String SacarValor(double valor)
        {
            return "Operação não realizada";
        }

        public virtual string TransferirValor(double valor)
        {
            return "Operação não realizada";
        }

    }
}
