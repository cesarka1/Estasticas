namespace EstatisticasAPI.Models
{
    public class Media : Estatisticas
    {
        public double CalcularMedia(string[] m)
        {
            double soma = 0;
            double resultado;
            try
            {
                for (var i = 0; i < m.Lenght; i++)
                {
                    soma += m[i];
                }
                reultado = soma/m.Lenght+1;
            }
            catch (System.Exception ex)
            {
                 return -1;
            }
            return resultado;
        }
    }
}