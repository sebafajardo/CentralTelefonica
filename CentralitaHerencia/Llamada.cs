using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Llamada:
//b. La clase Llamada, tendrá todos sus atributos con el modificador protected. Crear las propiedades de sólo lectura para exponer estos atributos.
//c. OrdenarPorDuracion es un método de clase que recibirá dos Llamadas. Se utilizará para ordenar una lista de llamadas de forma ascendente.
//d. Mostrar es un método de instancia. Utiliza StringBuilder.

namespace CentralitaHerencia
{

    public class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;



        public float Duracion { get { return _duracion; } }
        public string NroDestino { get { return _nroDestino; } }
        public string NroOrigen { get { return _nroOrigen; } }

        public Llamada(float duracion,string nroDestino,string nroOrigen)
        {
            this._duracion = duracion;
            this._nroDestino = nroDestino;
            this._nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Duracion: "+this._duracion.ToString());
            sb.AppendLine("Destino: "+this._nroDestino);
            sb.AppendLine("Origen: "+this._nroOrigen);

            return (sb.ToString());
        }
        //  OrdenarPorDuracion es un método de clase que recibirá dos Llamadas. 
        //   Se utilizará para ordenar una lista de llamadas de forma ascendente.
        public static int OrdenarPorDuracion(Llamada llamada1,Llamada llamada2)
        {
            if (llamada1.Duracion > 0 && llamada2.Duracion > 0)//Arreglar, si es mayor 1, si son iguales 0 y -1 si es menor.
                return 1;
                  return -1;
        }
    }

    public enum TipoLlamada { Local, Provincial, Todas }
}
