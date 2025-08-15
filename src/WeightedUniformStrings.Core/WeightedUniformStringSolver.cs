namespace WeightedUniformStrings.Core;

public class WeightedUniformStringSolver
{
    public List<string> WeightedUniformStrings(string s, List<int> queries)
    {
        List<string> letras = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"];
        List<int> valores = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26];
        List<string> cadenas = new List<string>();
        foreach (var letra in s)
        {
            string cadena = "";
            string temp = "";
            if (letra.ToString() != temp)
            {
                cadena = letra.ToString();
                cadenas.Add(cadena);
            }
            else { 
                cadena = cadena + letra.ToString();
                cadenas.Add(cadena);
            }

            temp = letra.ToString();
        }


    }
}
