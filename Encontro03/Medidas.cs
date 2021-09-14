using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    public abstract class Medidas : Veiculo
    {
        public double Altura { get; set; }

        public double Comprimento { get; set; }

        public int QtdDePortas { get; set; }

        public override void ImprimirDados()
        {
            base.ImprimirDados();
            Console.WriteLine("- Atributos da Classe Medidas.");
            Console.WriteLine("- Altura: {0}", this.Altura);
            Console.WriteLine("- Comprimento: {0}", this.Comprimento);
            Console.WriteLine("- QtdDePortas: {0}", this.QtdDePortas);
        }

        public Medidas(int codigoAoCriar) : base(codigoAoCriar)
        { }
    }
}
