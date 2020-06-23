namespace STATIC
{
    public static class CasadeCambio
    {
        public static float CotacaoRealDolar;
        
        public static float CotacaoRealEuro;

        public static float CambioDolar(float reais)
        {   
            float cambio = reais/CotacaoRealDolar;
            return cambio;
        }

        public static float CambioEuro(float reais)
        {
            float cambio = reais/CotacaoRealEuro;
            return cambio;
        }

        public static float CambioEuroReal(float euros)
        {
            float cambio = euros*CotacaoRealEuro;
            return cambio;
        }

        public static float CambioDolarReal(float dolares)
        {
            float cambio = dolares*CotacaoRealDolar;
            return cambio;
        }
    }
}