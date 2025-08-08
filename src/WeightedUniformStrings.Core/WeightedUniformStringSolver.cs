namespace WeightedUniformStrings.Core;

public class WeightedUniformStringSolver
{
    public List<string> WeightedUniformStrings(string s, List<int> queries)
    {
        List<int> conjunto = new List<int>();
        var subCadena = s.ToArray();
        for (int i = 0; i < subCadena.Length; i++)
        {
            string primeraLetra = subCadena[i].ToString();
            string segundaLetra = subCadena[i+1].ToString();

            if(primeraLetra == segundaLetra)
            {
               
            }
            else
            {

            }

        }

        return new List<string>();
    }

    private int PesoLetra(string letra)
    {
        int peso = 0;
       if(letra == "a")
        {
            peso = 1;
            return peso;

        }

        return peso;
    }
}
