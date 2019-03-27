using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFolhaPagto_RafaelDaigo2
{
    public static class Validacao
    {
        public static char ValidaNumeroReal(string texto, char tecla)
        {
            if (tecla == ',')
            {
                int index = texto.IndexOf(',');
                if (index > 0)
                    return (char)0;
            }
                
            if ((tecla < '0' || tecla > '9') && tecla != ',' && tecla != (Char)8 && tecla != (char)13)
            {
                return tecla = (Char)0;
            }
            return tecla;
        }
        public static char ValidaNumeroNatural(string texto, char tecla)
        {
            if (((tecla < '0' || tecla > '9') && tecla != (Char)8 && tecla != (char)13) || (tecla == ',' || tecla == '-'))
            {
                return tecla = (Char)0;
            }
            return tecla;

        }

        public static char ValidaCaracteres(string texto, char tecla)
        {
            if (!(char.IsLetter(tecla)) && tecla != (char)8 && tecla != (char)9 && tecla != (char)32 && tecla != (char)13)
            {
                return tecla = (char)0;
            }
            return tecla;
        }



    }
}
