using System;


namespace Recursivo
{
    public class Recur
    {
        

        public void GerarFibonacci(int num1,int num2, int vezes)
        {
            

            if(vezes>0)
            {
                Console.WriteLine(num1);
                GerarFibonacci(num2,num1+num2,vezes - 1);
               
            }
        }
    }
}