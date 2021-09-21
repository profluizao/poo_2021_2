using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    public class LocacaoDeMotocicleta : Locacao, ILocacao
    {
        private Motocicleta motocicletaParaLocacao;

        public Motocicleta MotocicletaParaLocacao
        {
            get => this.motocicletaParaLocacao;
            set => this.motocicletaParaLocacao = value;
        }

        public LocacaoDeMotocicleta() : base()
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
