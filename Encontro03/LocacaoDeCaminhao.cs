using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    public class LocacaoDeCaminhao : Locacao, ILocacao
    {
        private Caminhao caminhaoParaLocacao;

        public Caminhao CaminhaoParaLocacao
        {
            get => this.caminhaoParaLocacao;
            set => this.caminhaoParaLocacao = value;
        }

        public LocacaoDeCaminhao() : base()
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
