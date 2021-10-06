using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ValidadorDeInformacion
    {
        public static bool ValidarStringTexto(string cadenaAValidar)
        {
            if(cadenaAValidar is null || cadenaAValidar == "")
            {
                return false;
            }
            return true;
        }

        public static bool ValidarNumeroTelefono(string cadenaAValidar)
        {
            bool validador = true;
            if (cadenaAValidar is not null && cadenaAValidar != "")
            {
                char[] arrayTelefono = cadenaAValidar.ToCharArray();
                if (arrayTelefono.Length ==12)
                {
                    for (int i = 0; i < arrayTelefono.Length; i++)
                    {

                        if (validador == true && arrayTelefono[i] >= '0' && arrayTelefono[i] <= '9')
                        {
                            validador = true;
                        }
                        else
                        {
                            validador = false;
                        }
                    }
                }
                else
                {
                    validador = false;
                }
            }
            if (validador == true)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool ValidarDocumento(string cadenaAValidar)
        {
            bool validador = true;
            if(cadenaAValidar is not null && cadenaAValidar != "")
            {
                char[] arrayDocumento = cadenaAValidar.ToCharArray();
                if(arrayDocumento.Length == 8)
                {
                    for(int i=0;i<arrayDocumento.Length;i++)
                    {

                        if (validador == true &&  arrayDocumento[i] >= '0' && arrayDocumento[i] <= '9')
                        {
                            validador = true;
                        }
                        else
                        {
                            validador = false;
                        }
                    }
                }
                else
                {
                    validador = false;
                }
            }
            if(validador == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidarEdad(string cadenaAValidar)
        {
            if(cadenaAValidar is not null && cadenaAValidar != "")
            {
                int edadAValidar;
                if(int.TryParse(cadenaAValidar,out edadAValidar))
                {
                    return true;
                }
            }
            return false;
        }


    }
}
