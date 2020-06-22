namespace Aula22Static
{
    public class Conversor
    {
        
        public static float CotacaoDolar = 5.25f;

        public static float CotacaoEuro  = 5.91f;

        public static float RealParaDolar(float valor){

            return valor / CotacaoDolar;

        }

        public static float DolarParaReal(float valor){

            return valor * CotacaoDolar;

        }

        public static float RealParaEuro(float valor){

            return valor / CotacaoEuro;

        }

        public static float EuroParaReal(float valor){

            return valor * CotacaoEuro;

        }
    
        

    }
}