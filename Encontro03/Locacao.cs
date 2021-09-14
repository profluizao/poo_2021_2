using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    public abstract class Locacao
    {
        protected decimal valor;
        public decimal Valor
        {
            get => this.valor;
            set => this.valor = value;
        }

        protected DateTime dataInicial;
        public DateTime DataInicial
        {
            get => this.dataInicial;
            set => this.dataInicial = value;
        }

        protected DateTime dataFinal;
        public DateTime DataFinal
        {
            get => this.dataFinal;
            set => this.dataFinal = value;
        }

        protected string nomeLocatario;
        public string NomeLocatario
        {
            get => this.nomeLocatario;
            set => this.nomeLocatario = value;
        }

        protected string documentoLocatario;
        public string DocumentoLocatario
        {
            get => this.documentoLocatario;
            set => this.documentoLocatario = value;
        }
    }
}
