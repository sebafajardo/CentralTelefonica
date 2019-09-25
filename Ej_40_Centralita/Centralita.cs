using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Centralita:
//j. Se reemplaza el método Mostrar por la sobrescritura del método ToString.
//k. AgregarLlamada es privado. Recibe una Llamada y la agrega a la lista de llamadas.
//l. El operador == retornará true si la Centralita contiene la Llamada en su lista genérica. Utilizar
//sobrecarga == de Llamada.
//m. El operador + invocará al método AgregarLlamada sólo si la llamada no está registrada en la
//Centralita (utilizar la sobrecarga del operador == de Centralita).

namespace Ej_40_Centralita
{
    class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        public float GananciaPorLocal { get; }
        public float GananciaPorProvincial { get; }
        public float GananciaPorTotal { get; }
        public List<Llamada> Llamadas { get; }

        private void AgregarLlamada(Llamada nuevaLlamada)
        { 
         
        }

        private float CalcularGanancia(TipoLlamada tipo)
        { }
    }
}
