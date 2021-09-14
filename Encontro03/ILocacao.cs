using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encontro03
{
    public interface ILocacao
    {
        decimal Valor { get; set; }

        DateTime DataInicial { get; set; }

        DateTime DataFinal { get; set; }

        string NomeLocatario { get; set; }

        string DocumentoLocatario { get; set; }

        void Efetuar();

        void Devolver();

        void Renovar();

        void Cancelar();
    }
}
