namespace Recursivo
{
    public class Fatorial
    {
        public int Fator(int num)
        {
            if(num==1)
            {
                return 1;
                
            }else
            {
                return num * Fator(num - 1);
            }

    
        }
    }
}