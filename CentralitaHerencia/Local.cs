using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Local:
//e. Heredará de Llamada.
//f. Método Mostrar expondrá, además de los atributos de la clase base, la propiedad
//   CostoLlamada. Utilizar StringBuilder.
//g. CalcularCosto será privado. Retornará el valor de la llamada a partir de la duración y el costo
//   de la misma.
//h. La propiedad CostoLlamada retornará el precio, que se calculará en el método


namespace CentralitaHerencia
{
    class Local:Llamada
    {
        protected float _costo;
        public float CostoLlamada { get { return CalcularCosto(); } }

        private float CalcularCosto()
        {        
                _costo = this.Duracion * 0.66f;
            return _costo;
        }

        public Local(Llamada llamada, float costo):base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this._costo = costo;
        }
        public Local(string nroOrigen, float duracion, string nroDestino, float costo)
            : base(duracion, nroDestino, nroOrigen)
        {
            this._costo = costo;
        }

        public string Mostrar()
        {
            return this._costo.ToString() + base.Mostrar();
        }
    }
}
