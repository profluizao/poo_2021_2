using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    public abstract class Veiculo
    {
        protected int codigo;

        public int Codigo { get => this.codigo; }

        public string Autonomia { get; set; }

        public string Cor { get; set; }

        public DateTime DataDeFabricacao { get; set; }

        public string Modelo { get; set; }

        public string Nome { get; set; }

        public string NumeroDeChassi { get; set; }

        public string TipoDeCambio { get; set; }

        public string TipoDeCombustivel { get; set; }

        public string TipoDeMotor { get; set; }

        public abstract void Desligar();

        public virtual void ImprimirDados()
        {
            Console.WriteLine("# Atributos da Classe Veículo");
            Console.WriteLine("# Codigo: {0}", this.codigo);
            Console.WriteLine("# Autonomia: {0}", this.Autonomia);
            Console.WriteLine("# Cor: {0}", this.Cor);
            Console.WriteLine("# Data de Fabricação: {0}", this.DataDeFabricacao.ToString());
            Console.WriteLine("# Modelo: {0}", this.Modelo);
            Console.WriteLine("# Nome: {0}", this.Nome);
            Console.WriteLine("# Numero de Chassi: {0}", this.NumeroDeChassi);
            Console.WriteLine("# Tipo de Câmbio: {0}", this.TipoDeCambio);
            Console.WriteLine("# Tipo de Combustível: {0}", this.TipoDeCombustivel);
            Console.WriteLine("# Tipo de Motor: {0}", this.TipoDeMotor);
        }

        public abstract void Ligar();

        public Veiculo(int codigoAoCriar)
        {
            this.codigo = codigoAoCriar;
        }

    }
}
