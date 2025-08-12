namespace WeightedUniformStrings.Core;

public class WeightedUniformStringSolver
{
    public List<string> WeightedUniformStrings(string s, List<int> queries)
    {
        try
        {
            var Conjunto = new Dictionary<int, int>();
            List<string> ListaStrings = new List<string>();


            foreach (var item in s)
            {
                ListaStrings.Add(item.ToString());
                
                if (Conjunto.ContainsKey(item))
                {

                    Conjunto[item] = item;
                }
                else
                {
                    Conjunto[item] = 1;
                }
            }

            return ListaStrings;
        }
        catch (System.Exception exc)
        {

            throw;
        }
    }
}
