namespace EstatisticasAPI.Models
{
    public class Media : Estatisticas
    {
        public double CalcularMedia(string[] m)
        {
            double soma = 0;
            double resultado = 0;
            try
            {
                for (var i = 0; i < m.Length; i++)
                {
                    soma += double.Parse(m[i]);
                }
                resultado = soma/m.Length;
            }
            catch (System.Exception)
            {
                 return -1;
            }
            return resultado;
        }
    }
}