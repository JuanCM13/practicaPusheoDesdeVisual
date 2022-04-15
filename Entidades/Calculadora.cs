using System;

namespace Entidades
{
    public static class Calculadora
    {

        public static double Operar(Operando o1 , Operando o2 , Char operador)
        {
            char operadorValidado = Calculadora.ValidarOperando(operador);
            double result;

            switch (operadorValidado)
            {
                case '+':
                    result = o1 + o2;        
                break;
                case '/':
                    result = o1 / o2;
                break;
                case '*':
                    result = o1 * o2;
                break;
                default:
                    result = o1 - o2;
                break;
            }
            return result;
        }

        /// <summary>
        /// Valida si el operador es + , - , * o /, de lo contrario retorna +
        /// </summary>
        /// <param name="operador">Caracter a verificar</param>
        /// <returns> operador || + </returns>
        private static char ValidarOperando(Char operador)
        {
            char ret = operador;

            if(operador != '+' && operador != '-' && operador != '*' && operador != '/')
            {
                ret = '+';
            }
            return ret;
        }


    }
}
