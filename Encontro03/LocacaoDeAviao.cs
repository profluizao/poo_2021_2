using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    public class LocacaoDeAviao : Locacao, ILocacao
    {
        private Aviao aviaoParaLocacao;

        public Aviao AviaoParaLocacao
        {
            get => this.aviaoParaLocacao;
            set => this.aviaoParaLocacao = value;
        }

        public LocacaoDeAviao() : base()
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
