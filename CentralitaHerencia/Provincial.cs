using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Provincial:

//i. Hederará de Llamada
//j. Método Mostrar expondrá, además de los atributos de la clase base, la propiedad
//   CostoLlamada y franjaHoraria. Utilizar StringBuilder.
//k. CalcularCosto será privado. Retornará el valor de la llamada a partir de la duración y el costo
//   de la misma. Los valores serán: Franja_1: 0.99, Franja_2: 1.25 y Franja_3: 0.66

namespace CentralitaHerencia
{
    public class Provincial:Llamada
    {
        public enum Franja { Franja_1 , Franja_2 , Franja_3}

        protected Franja _franjaHoraria;

        public float CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            float costo = 0;
            if (this._franjaHoraria == Franja.Franja_1)
                costo = this.Duracion * 0.99f;
            if (this._franjaHoraria == Franja.Franja_2)
                costo = this.Duracion * 1.25f;
            else
                costo = this.Duracion * 0.66f;
            return costo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Franja horaria: "+this._franjaHoraria);
            sb.AppendLine("Costo de llamada: "+this.CostoLlamada);

            return (sb.ToString() + base.Mostrar());

        }

        public Provincial(Franja miFranja,Llamada llamada):base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this._franjaHoraria = miFranja;
        }

        public Provincial(string origen,Franja miFranja,float duracion,string destino):base(duracion,destino,origen)   
        {
            this._franjaHoraria = miFranja;
        }
    }
    
}
