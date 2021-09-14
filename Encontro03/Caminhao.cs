using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    public class Caminhao : Medidas
    {
        public int QtdDeEixos { get; set; }

        public override void Desligar()
        {
            Console.WriteLine("Desligando o Caminhao.");
        }

        public override void ImprimirDados()
        {
            base.ImprimirDados();
            Console.WriteLine("Atributos da Classe Caminhao.");
            Console.WriteLine("QtdDeEixos: {0}", this.QtdDeEixos);
        }

        public override void Ligar()
        {
            Console.WriteLine("Ligando o Caminhao.");
        }


        public Caminhao(int codigoAoCriar) : base(codigoAoCriar)
        { }
    }
}
