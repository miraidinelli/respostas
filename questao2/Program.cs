using System;
namespace Projcs
{
    public class resposta
    {
        static void Main(string[] args)
        {
            bool verFibonacci(int n)
            {
                int a = 0;
                int b = 1;
                if (n==a || n==b) 
                return true;
                int c = a+b;
                while(c<=n)
                {
                    if(c == n) 
                    return true;
                    a = b;
                    b = c;
                    c = a + b;
                    return false;
                }
            }
        }
    }
}