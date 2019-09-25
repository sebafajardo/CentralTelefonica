using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Llamada:
// a. La clase Llamada ahora será abstracta. Tendrá definida la propiedad de sólo lectura
//     CostoLlamada que también será abstracta.


namespace Ej_40_Centralita
{
    public abstract class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public abstract float CostoLlamada { get; }
        public float  Duracion { get; }
        public string NroDestino { get; }
        public string NroOrigen { get; }

        public Llamada(float duracion,string nroDestino,string nroOrigen)
        {
            this._duracion = duracion;
            this._nroDestino = nroDestino;
            this._nroOrigen = nroOrigen;
        }

        // b. Mostrar deberá ser declarado como virtual, protegido y retornará un string que contendrá
        //     los atributos propios de la clase Llamada

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duracion: "+_duracion.ToString());
            sb.AppendLine("Destino: "+_nroDestino);
            sb.AppendLine("Origen: " + _nroOrigen);

            return sb.ToString();
        }

        // c. El operador == comparará dos llamadas y retornará true si las llamadas son del mismo tipo
        //     (utilizar método Equals, sobrescrito en las clases derivadas) y los números de destino y
        //      origen son iguales en ambas llamadas.

        public static bool operator ==(Llamada l1, Llamada l2)
        {
         // if(l1 is Local && l2 is Local)
         //return true;
         // if (l1 is Provincial && l2 is Provincial)
         //     return true;
         // return false;
            if ((l1.GetType()) == typeof(Local) && (l2.GetType()) == typeof(Local) && l1._nroDestino==l2._nroDestino)
                return true;                         
            if ((l1.GetType()) == typeof(Provincial) && (l2.GetType()) == typeof(Provincial)&& l1._nroDestino==l2._nroDestino)
                return true;
            return false;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
          return !(l1==l2);
        }

        public int OrdenarPorDuracion(Llamada llamada1,Llamada llamada2)
        {
            if (llamada1._duracion > llamada2._duracion)
                return 1;
            if (llamada1._duracion < llamada2._duracion)
                return -1;
            return 0; //Si son iguales.

        }
    }
    public enum TipoLlamada { Local, Provincial, Todas }
}
