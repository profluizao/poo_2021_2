using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    class Program
    {
        static void Main(string[] args)
        {
            Motocicleta obj1 = new Motocicleta(1);
            obj1.Autonomia = "1000";
            obj1.Cilindradas = 1000;
            obj1.Cor = "Azul";
            obj1.DataDeFabricacao = new DateTime(2021, 9, 13);
            obj1.Modelo = "Esportiva";
            obj1.Nome = "CB";
            obj1.NumeroDeChassi = "321654987";
            obj1.TipoDeCambio = "manual";
            obj1.TipoDeCombustivel = "Gasolina";
            obj1.TipoDeMotor = "Turbo";

            Carro obj2 = new Carro(2)
            {
                Altura = 2.0,
                Autonomia = "1000",
                Comprimento = 2.5,
                Conversivel = false,
                Cor = "Vermelho",
                DataDeFabricacao = new DateTime(2020,5,7),
                Modelo = "Passeio",
                Nome = "Mareia",
                NumeroDeChassi = "321654987",
                QtdDePortas = 4,
                TipoDeCambio = "Automático",
                TipoDeCombustivel = "BiCombustível",
                TipoDeMotor = "5 Cilindros"
            };

            Console.WriteLine("Imprimindo dados do obj1:");
            obj1.ImprimirDados();
            
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Imprimindo dados do obj2:");
            obj2.ImprimirDados();

            Console.ReadLine();
        }
    }
}
