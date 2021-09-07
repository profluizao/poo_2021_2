using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    public abstract class Veiculo
    {
        public int Codigo { get; set; }

        public string Autonomia { get; set; }

        public string Cor { get; set; }

        public DateTime DataDeFabricacao { get; set; }

        public string Modelo { get; set; }

        public string Nome { get; set; }

        public string NumeroDeChassi { get; set; }

        public string TipoDeCambio { get; set; }

        public string TipoDeCombustivel { get; set; }

        public string TipoDeMotor { get; set; }

        public void Desligar()
        { }

        public void ImprimirDados()
        { }

        public void Ligar()
        { }

        public Veiculo()
        { }

    }
}
