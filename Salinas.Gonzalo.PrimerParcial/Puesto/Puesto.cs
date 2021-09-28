using System;

namespace Puesto
{
    public abstract class Puesto
    {
        protected string identificador;
        protected bool enUso;
        protected string dniCliente;

        protected Puesto(string identificador, bool enUso,string dniCliente)
        {
            Identificador= identificador;
            EnUso = enUso;
            DniCliente = dniCliente;
        }

        public abstract string Identificador { get; set; }
        public abstract string DniCliente { get; set; }
        public abstract bool EnUso { get; set; }


        

        
    }
}
