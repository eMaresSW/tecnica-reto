namespace WeightedUniformStrings.Core;

public class WeightedUniformStringSolver
{

    public static List<string> WeightedUniformStrings(string s, List<int> queries)
    {
        List<string> letras = new List<string>
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
            "k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s",
            "t", "u", "v", "w", "x", "y", "z"
        };

        List<int> valores = new List<int>
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
            11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
            21, 22, 23, 24, 25, 26
        };

        List<Cadena> cadenas = new List<Cadena>();
        List<int> u = new List<int>();
        List<string> resp = new List<string>();
        string temp = "";
        string cadena = "";
        int valor = 0;

        foreach (var letra in s)
        {
            int posicion = Array.IndexOf(letras.ToArray(), letra.ToString());
            if (letra.ToString() != temp)
            {
                cadena = letra.ToString();
                valor = valores[posicion];

            }
            else
            {
                cadena = cadena + "" + letra.ToString();
                valor += valores[posicion];
            }
            cadenas.Add(new Cadena { cadena = cadena, valor = valor });
            u.Add(valor);
            temp = letra.ToString();
        }
        int suma = cadenas.Sum(c => c.valor);

        foreach (var q in queries)
        {
            bool existe = Array.Exists(u.ToArray(), n => n == q);
            if (existe)
            {
                resp.Add("Yes");
            }
            else
            {
                resp.Add("No");
            }
        }


        return resp;
    }

    public class Cadena
    {
        public string cadena { get; set; }
        public int valor { get; set; }
    }
}
