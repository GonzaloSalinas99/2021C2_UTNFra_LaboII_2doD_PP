using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ValidadorDeInformacion
    {
        /// <summary>
        /// Valida que el parametro no sea un string vacio y si es un numero.
        /// </summary>
        /// <param name="cadenaAValidar">Cadena a validar</param>
        /// <returns>True si no esta vacion el string y es un numero o False si no lo es</returns>
        public static bool ValidarNumero(string cadenaAValidar)
        {
            int auxiliar;
            if(ValidarStringTexto(cadenaAValidar) &&  int.TryParse(cadenaAValidar,out auxiliar))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Valida que la cadena no sea null ni este vacio
        /// </summary>
        /// <param name="cadenaAValidar">Cadena a validar</param>
        /// <returns>True si esta correcta, false si no lo esta</returns>
        public static bool ValidarStringTexto(string cadenaAValidar)
        {
            if(String.IsNullOrWhiteSpace(cadenaAValidar))
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Valida el numero de telefono, que sea solo numeros
        /// </summary>
        /// <param name="cadenaAValidar">Numero de telefon oa validar</param>
        /// <returns>True si es un numero de telefono, false si no lo es</returns>
        public static bool ValidarNumeroTelefono(string cadenaAValidar)
        {
            bool validador = true;
            if (ValidarStringTexto(cadenaAValidar))
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
        /// <summary>
        /// Valida el numero de documento
        /// </summary>
        /// <param name="cadenaAValidar">Documento a validar</param>
        /// <returns>true si es un numero de documento correcto, false si no lo es</returns>
        public static bool ValidarDocumento(string cadenaAValidar)
        {
            bool validador = true;
            if(ValidarStringTexto(cadenaAValidar))
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
        /// <summary>
        /// Valida la edad
        /// </summary>
        /// <param name="cadenaAValidar">Edad a validar</param>
        /// <returns>True si es una edad valida, false si no lo es</returns>
        public static bool ValidarEdad(string cadenaAValidar)
        {
            if(ValidarStringTexto(cadenaAValidar))
            {
                int edadAValidar;
                if(int.TryParse(cadenaAValidar,out edadAValidar))
                {
                    if(edadAValidar>3 && edadAValidar<100)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Valida que el string no este vacio y que tenga una determinada cantidad de caracteres
        /// </summary>
        /// <param name="cadenaAValidar">Cadena a validar</param>
        /// <param name="cantidadCaracteresPermitidos">Cantidad de caracteres a comparar</param>
        /// <returns>True si no esta vacio el string y cumple con la cantidad de caracteres pasados por parametros o False si no cumple con los requisitos</returns>
        public static bool ValidarCantidadCaracteresString(string cadenaAValidar,int cantidadCaracteresPermitidos)
        {
            if(ValidarStringTexto(cadenaAValidar) && cadenaAValidar.Length == cantidadCaracteresPermitidos)
            {
                return true;
            }
            return false;
        }

    }
}
