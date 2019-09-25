using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Centralita:
//l. CalcularGanancia será privado. Este método recibe un Enumerado TipoLlamada y retornará
//   el valor de lo recaudado, según el criterio elegido (ganancias por las llamadas del tipo Local,
//   Provincial o de Todas según corresponda).
//m. El método Mostrar expondrá la razón social, la ganancia total, ganancia por llamados locales
//    y provinciales y el detalle de las llamadas realizadas.
//n. La lista sólo se inicializará en el constructor por defecto Centralita().
//o. Las propiedades GananciaPorTotal, GananciaPorLocal y GananciaPorProvincial retornarán el
//    precio de lo facturado según el criterio. Dichos valores se calcularán en el método
//    CalcularGanancia().
//    Generar un nuevo proyecto del tipo Console Application llamado Test. El namespace también
//     deberá llamarse Test. Agregar el siguiente código en el Main para probar la Centralita.
namespace CentralitaHerencia
{ 
    class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        public float GananciasPorLocal { get { return CalcularGanancia(TipoLlamada.Local); } }
        public float GananciasPorProvincial { get { return CalcularGanancia(TipoLlamada.Provincial); } }
        public float GananciasPorTotal { get { return CalcularGanancia(TipoLlamada.Todas); } }
        public List<Llamada> Llamadas { get { return _listaDeLlamadas; } }

        public Centralita()
        {
            _listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this._razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float resultado=0;
            //float _gananciaTodas=0
            float _gananciaLocal=0,_gananciaProvincial=0;
            foreach (Llamada item in _listaDeLlamadas)
            {
                if (item.GetType() == typeof(Local))
                {
                    _gananciaLocal+= item.Duracion * 0.66f; //Supongo que local tiene como valor 0.66
                }

                if (item.GetType() == typeof(Provincial))
                {
                    _gananciaProvincial += ((Provincial)item).CostoLlamada;
                }
                //else
                //    _gananciaTodas = _gananciaProvincial + _gananciaLocal;
                switch (tipo)
                {                      
                    case TipoLlamada.Local:
                       resultado=_gananciaLocal;
                       break;
                    case TipoLlamada.Provincial:
                       resultado= _gananciaProvincial;
                       break;
                    case TipoLlamada.Todas:
                       resultado= (_gananciaLocal + _gananciaProvincial);
                       break;               
                }
             
            }
            return resultado;
        }
 //   El método Mostrar expondrá la razón social, la ganancia total, ganancia por llamados locales
 //    y provinciales y el detalle de las llamadas realizadas.
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Razon social: "+_razonSocial);
            sb.AppendLine("Locales: "+GananciasPorLocal);
            sb.AppendLine("Provinciales: "+GananciasPorProvincial);
            sb.AppendLine("Total: "+GananciasPorTotal);
            sb.AppendLine("Detalle de llamadas: ");

            foreach (Llamada item in _listaDeLlamadas)
            {
                item.Mostrar();
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
