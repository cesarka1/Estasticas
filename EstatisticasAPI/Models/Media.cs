namespace EstatisticasAPI.Models
{
    public class Media : Estatisticas
    {
        public double CalcularMedia(string m)
        {
            string[] valoresstring = m.Split(" ");
            double[] valores = new double[valoresstring.Length];
            double soma = 0;
            double resultado = 0;
            try
            {
                for (var i = 0; i < valoresstring.Length; i++)
                {
                    valores[i] = double.Parse(valoresstring[i]);
                }

                for (var i = 0; i < valores.Length; i++)
                {
                    soma += valores[i];
                }
                resultado = soma/valores.Length;
            }
            catch (System.Exception)
            {
                 return -1;
            }
            return resultado;
        }
    }
}