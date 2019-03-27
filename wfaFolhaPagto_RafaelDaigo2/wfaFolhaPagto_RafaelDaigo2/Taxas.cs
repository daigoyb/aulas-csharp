using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaFolhaPagto_RafaelDaigo2
{
    class Taxas
    {
        #region Variáveis

        static float salbruto;
        static float valinss;
        static float base_calculo;
        static float valirr;
        static float salliquido;

        #endregion

        #region Métodos

        public static float CalcularSalBruto(float horastrab, float valorhora)
        {
            salbruto = horastrab * valorhora;
            return salbruto;
        }
        public static float CalcularINSS(float salbruto)
        {
            if (salbruto <= 965.67)
                valinss = salbruto * (float)0.08;
            else if (salbruto > 965.67 && salbruto <= 1609.45)
                valinss = salbruto * (float)0.09;
            else if (salbruto > 1609.45 && salbruto <= 3218.90)
                valinss = salbruto * (float)0.11;
            else
                valinss = (float)354.08;
            return valinss;
        }

        public static float CalcularIRR(float salbruto, float valinss, int num_dependentes)
        {
            base_calculo = salbruto - valinss - (num_dependentes * (float)144.2);
            if (base_calculo < 0)
                return 0;
            else if (base_calculo <= 1434.59)
                valirr = base_calculo;
            else if (base_calculo > 1434.59 && base_calculo <= 2150)
                valirr = (base_calculo * (float)0.075) - (float)107.59;
            else if (base_calculo > 2150 && base_calculo <= 2866.70)
                valirr = (base_calculo * (float)0.15) - (float)268.84;
            else if (base_calculo > 2866.7 && base_calculo <= 3582)
                valirr = (base_calculo * (float)0.225) - (float)483.84;
            else
                valirr = (base_calculo * (float)0.275) - (float)662.94;
            return valirr;
        }

        public static float CalcularSalLiquido(float salbruto, float valinss, float valirr)
        {
            salliquido = salbruto - valinss - valirr;
            return salliquido;
        }
        #endregion
    }
}
