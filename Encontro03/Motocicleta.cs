using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    public class Motocicleta : Veiculo
    {
        public int Cilindradas { get; set; }

        public Motocicleta(int codigoAoCriar) : base(codigoAoCriar)
        { }

        public override void Desligar()
        {
            Console.WriteLine("Desligando a motocicleta.");
        }

        public override void ImprimirDados()
        {
            base.ImprimirDados();
            Console.WriteLine("Atributos da Classe Motocicleta.");
            Console.WriteLine("Cilindradas: {0}", this.Cilindradas);
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligando a motocicleta.");
        }
    }
}
