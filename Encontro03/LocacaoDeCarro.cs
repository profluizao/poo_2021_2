using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    public class LocacaoDeCarro : Locacao, ILocacao
    {
        private Carro carroParaLocacao;
        public Carro CarroParaLocacao 
        { 
            get => this.carroParaLocacao; 
            set => this.carroParaLocacao = value; 
        }
        public void Cancelar()
        {
            throw new NotImplementedException();
        }

        public void Devolver()
        {
            throw new NotImplementedException();
        }

        public void Efetuar()
        {
            throw new NotImplementedException();
        }

        public void Renovar()
        {
            throw new NotImplementedException();
        }
    }
}
