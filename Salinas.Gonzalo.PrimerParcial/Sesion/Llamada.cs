using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cliente;
using Puesto;
namespace Sesion
{
    class Llamada : Sesion
    {

        public Llamada(DateTime tiempoInicio)
        {
            TiempoInicio = tiempoInicio;
           // TiempoFinal = 
        }

        public override DateTime TiempoInicio
        {
            get { return this.tiempoInicio; }
            set { this.tiempoInicio = value; }
        }
        public override DateTime TiempoFinal
        {
            get { return this.tiempoFinal; }
            set { this.tiempoFinal = value; }
        }




        public override double CalcularPrecioACobrar(DateTime inicio,DateTime final)
        {
            return final.Subtract(inicio).TotalMinutes;
        }

        public bool AsignarTelefonoACliente(List<Telefono> listaTelefonos,List<ClienteTelefono>listaClientes)
        {
            foreach (Telefono telefono in listaTelefonos)
            {
                foreach (ClienteTelefono cliente in listaClientes)
                {
                    if(telefono.TipoLlamada == cliente.TipoLlamada && telefono.EnUso == false)
                    {
                        telefono.DniCliente = cliente.Dni;
                        telefono.NumeroTelefono = cliente.NumeroTelefono;
                        telefono.EnUso = true;
                        this.TiempoInicio = DateTime.Now;
                        //this.tiempoFinal = ;
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
