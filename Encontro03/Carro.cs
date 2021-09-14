using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    public class Carro : Medidas
    {
        public bool Conversivel { get; set; }

        public override void Desligar()
        {
            Console.WriteLine("Desligando o Carro.");
        }

        public override void ImprimirDados()
        {
            base.ImprimirDados();
            Console.WriteLine("Atributos da Classe Carro.");
            Console.WriteLine("Conversivel: {0}", this.Conversivel);
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligando o Carro.");
        }

        public Carro(int codigoAoCriar) : base(codigoAoCriar)
        { }
    }
}
