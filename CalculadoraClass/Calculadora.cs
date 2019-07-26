using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraClass
{
    public class Calculadora
    {

        
        public float Soma(float num1, float num2)
        {

            return num1 + num2;
             
        }
        public float Subtracao(float num1, float num2)
        {
            return num1 - num2;
            

        }
        public float Multiplicacao(float num1, float num2)
        {
            return  num1 * num2;
            

        }
        public float Divisao(float num1, float num2)
        {
            return num1 / num2;
            

        }
        public float AreaRetangulo(float num1, float num2)
        {
            return num1 * num2;
            
        }
        public float AreaTrianguloEquilatero(float num1, float num2)
        {
            return (num1 * num2) / 2;
            
        }
        public float RaioCirculo(float num1)
        {
            
            return num1 / 2;
            
        }

    }
}

