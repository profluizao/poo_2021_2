using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    public class Aviao : Medidas
    {
        public int QtdDeAssentos { get; set; }

        public int QtdDeBanheiros { get; set; }

        public override void Desligar()
        {
            Console.WriteLine("Desligando o Avião.");
        }

        public override void ImprimirDados()
        {
            base.ImprimirDados();
            Console.WriteLine("Atributos da Classe Avião.");
            Console.WriteLine("QtdDeAssentos: {0}", this.QtdDeAssentos);
            Console.WriteLine("QtdDeBanheiros: {0}", this.QtdDeBanheiros);
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligando o Avião.");
        }

        public Aviao(int codigoAoCriar) : base(codigoAoCriar)
        { }
    }
}
