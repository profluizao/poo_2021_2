using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    public class Navio : Medidas
    {
        public int QtdDeCabines { get; set; }

        public override void Desligar()
        {
            Console.WriteLine("Desligando o Navio.");
        }

        public override void ImprimirDados()
        {
            base.ImprimirDados();
            Console.WriteLine("Atributos da Classe Navio.");
            Console.WriteLine("QtdDeCabines: {0}", this.QtdDeCabines);
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligando o Navio.");
        }

        public Navio(int codigoAoCriar) : base(codigoAoCriar)
        { }
    }
}
