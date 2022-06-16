namespace EstatisticasAPI.Models
{
    public class Mediana 
    {
        public double CalcularMediana(string m)
        {
            string[] valoresstring = m.Split(" ");
            double[] valores = new double[valoresstring.Length];
            double mediana = 10;
            double aux;
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
                
                if (valores.Length % 2 == 0)
                {
                   mediana = (valores[(valores.Length/2)] + valores[(valores.Length/2)+1])/2;
                }
                else
                {
                   mediana = valores[valores.Length/2];
                }
                
            }
            catch (System.Exception)
            {
                
                return -1;
            }
            return mediana;
        }
    }
}