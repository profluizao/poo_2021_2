using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    public class LocacaoDeNavio : Locacao, ILocacao
    {
        private Navio navioParaLocacao;

        public Navio NavioParaLocacao
        {
            get => this.navioParaLocacao;
            set => this.navioParaLocacao = value;
        }

        public LocacaoDeNavio() : base()
        { }

        public void Efetuar()
        {
            throw new NotImplementedException();
        }

        public void Devolver()
        {
            throw new NotImplementedException();
        }

        public void Renovar()
        {
            throw new NotImplementedException();
        }

        public void Cancelar()
        {
            throw new NotImplementedException();
        }
    }
}
