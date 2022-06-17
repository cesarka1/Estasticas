namespace EstatisticasAPI.Models
{
    public class Minimo : Estatisticas
    {
        public double EcontrarMinimo(string m)
        {
            string[] valoresstring = m.Split(" ");
            double[] valores = new double[valoresstring.Length];
            double aux;
            try
            {
                //Passar valores do array string para o double
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
            }
            catch (System.Exception)
            {
                 return -1;
            }
            return valores[0];
        }
    }
}