using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmCiberCafe
{    
    public enum TipoTelefono
    {
        Disco,Teclado
    }

    

    public class Telefono : Administracion
    {
        private string identificador;
        private string marca;
        private TipoTelefono tipoTelefono;
        private float costoUso;
        private string numeroTelefono;


        public Telefono(string identificador, string marca, TipoTelefono tipoTelefono, string numeroTelefono)
        {
            Identificador= identificador;
            Marca= marca;
            TipoTelefono= tipoTelefono;
            NumeroTelefono = numeroTelefono;
            
        }

        public string Identificador
        {
            get { return this.identificador; }
            set 
            {
                string retorno = "Valor Invalido";
                char[] array = value.ToCharArray();

                if(array.Length>0 && array.Length<4)
                {
                    for(int i=0;i<array.Length;i++)
                    {
                        if(array[0] != 'T' && (array[1] != '0' && array[2]<'0' ||array[2]>'9'))
                        {
                            break;
                        }
                    }
                    retorno = array.ToString();
                }

                this.identificador = array.ToString();
            }
        }

        public string Marca
        {
            get { return this.marca; }
            set 
            {
                if(value is not null && value != "")
                {
                    this.marca = value;
                }
            }
        }

        public TipoTelefono TipoTelefono
        {
            get { return this.tipoTelefono; }
            set 
            {
                if(value == TipoTelefono.Disco || value == TipoTelefono.Teclado)
                {
                    this.tipoTelefono = value;
                }
            }
        }

        public string NumeroTelefono
        {
            get { return this.numeroTelefono; }
            set 
            { 
                if((value is not null || value != "")  && value.Length == 13)
                {
                    this.numeroTelefono = value;
                    
                }
            }
        }

        public float CostoUso
        {
            get { return this.costoUso;}
            
        }

        
        public float CalcularCostoLlamada()
        {

        }

        public int CalcularDistanciaLlamada()
        {
            char[] arrayTelefono = this.numeroTelefono.ToCharArray();
        
            for(int i = 0; i<arrayTelefono.Length; i++)
            {
                if(arrayTelefono[0] == '5')


            }
        
        }







    }
}
