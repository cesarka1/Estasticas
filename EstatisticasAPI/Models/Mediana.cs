namespace EstatisticasAPI.Models
{
    public class Mediana 
    {
        public double CalcularMediana(string[] m)
        {
            double mediana = 0;
            string aux;
            try
            {
                //Organizar Roll
                for (int i = 0; i < m.Length; i++)
                {
                    for (int x = i+1; x < m.Length; x++)
                    {
                       if (double.Parse(m[i]) > double.Parse(m[x]))
                       {
                        aux = m[i];
                        m[i] = m[x];
                        m[x] = aux;
                       }
                    }
                }
                if ((m.Length%2) != 0)
                {
                    mediana = double.Parse(m[(m.Length/2)]);
                }
                else
                {
                   mediana = (double.Parse(m[(m.Length/2)]) + double.Parse(m[(m.Length/2)+1]) )/2 -1 ;
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