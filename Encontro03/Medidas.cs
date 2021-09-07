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

        public Medidas()
        { }
    }
}
