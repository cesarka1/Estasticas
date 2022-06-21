namespace EstatisticasAPI.Models
{
    public class Moda 
    {
        public double CalcularModa(string m)
        {
            string[] valoresstring = m.Split(" ");
            double[] valores = new double[valoresstring.Length];
            double aux;
            double moda = 0;
            int contagem = 0;
            int contagem_anterior = 0;
            try
            {
                for (var i = 0; i < valoresstring.Length; i++)
                {
                    valores[i] = double.Parse(valoresstring[i]);
                }

                //Organizar Roll
                for (int i = 0; i < valores.Length; i++)
                {
                    for (int x = i+1; x < valores.Length; x++)
                    {
                       if (valores[i] > valores[x])
                       {
                        aux = valores[i];
                        valores[i] = valores[x];
                        valores[x] = aux;
                       }
                    }
                }
                
                for (int i = 0; i < valores.Length; i++)
                {
                    int x = i+1;
                    contagem = 0;
                    
                        while (valores[i] == valores[x] & x <= valores.Length-1)
                        {
                           contagem+= 1;
                           if ( x < valores.Length-1)
                            {
                                x++;
                            }
                         }
                    

                    if (i == 0)
                    {
                        moda = valores[0];
                    }
                    else
                    {
                        if (contagem > contagem_anterior)
                        {
                            moda = valores[i];
                        }
                    }
                    i = x -1;
                    contagem_anterior = contagem;
                    

                }

                
            }
            catch (System.Exception)
            {
                return -1;
            }
            return contagem_anterior;
        }
    }
}