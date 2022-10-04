using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Validacion
    {
        private static bool ValidarTexto(string textoIngresado)
        {
            bool ret = false;

            if (!String.IsNullOrWhiteSpace(textoIngresado))
            {
                ret = true;
            }
            return ret;
        }

        public static bool ValidarAlfabetico(string textoIngresado)
        {
            bool ret = Validacion.ValidarTexto(textoIngresado);
            string minuscula;

            if(ret)
            {
                minuscula = textoIngresado.ToLower();
                foreach (char item in minuscula)
                {
                    if ((item < 'a' || item > 'z') && item != ' ')
                    {
                        ret = false;
                        break;
                    }
                }
            }
            return ret;
        }

        public static bool ValidarNumerico(string textoIngresado)
        {
            bool ret = Validacion.ValidarTexto(textoIngresado);

            if (ret)
            {
                foreach (char item in textoIngresado)
                {
                    if (item < '0' || item > '9')
                    {
                        ret = false;
                        break;
                    }
                }
            }
            return ret;
        }

        public static bool ValidarAlfanumerico(string textoIngresado)
        {
            bool ret = Validacion.ValidarTexto(textoIngresado);

            if (ret)
            {
                foreach (char item in textoIngresado)
                {
                    if (!((item>='A') && (item<='Z')) && !((item >= 'a') && (item <= 'z')) && !((item >= '0') && (item <= '9')))
                    {
                        ret = false;
                        break;
                    }
                }
            }
            return ret;
        }


    }
}
