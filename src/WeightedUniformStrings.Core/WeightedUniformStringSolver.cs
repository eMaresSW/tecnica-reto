namespace WeightedUniformStrings.Core;

public class WeightedUniformStringSolver
{
    public List<string> WeightedUniformStrings(string s, List<int> queries)
    {
        //Variables de entrada
        Dictionary<string, int> cadenaPonderada = new Dictionary<string, int>()
        {
            ["a"] = 1,
            ["b"] = 2,
            ["c"] = 3,
            ["d"] = 4,
            ["e"] = 5,
            ["f"] = 6,
            ["g"] = 7,
            ["h"] = 8,
            ["i"] = 9,
            ["j"] = 10,
            ["k"] = 11,
            ["l"] = 12,
            ["m"] = 13,
            ["n"] = 14,
            ["o"] = 15,
            ["p"] = 16,
            ["q"] = 17,
            ["r"] = 18,
            ["s"] = 19,
            ["t"] = 20,
            ["u"] = 21,
            ["v"] = 22,
            ["w"] = 23,
            ["x"] = 24,
            ["y"] = 25,
            ["z"] = 26
        };
        List<string> result = [];


        //string example = "abbcdcddcddddcdde";
        //int[] queriesexample = [1, 7, 5, 4, 15];

        int pesoOriginal = 0;
        if (cadenaPonderada.ContainsKey(s))
        {
            pesoOriginal = cadenaPonderada[s];
        }

        int count = s.Length;
        int peso = 0;

        foreach(var query in queries)
        {
            for (var x = 0; x <= count; x++)
            {
                if (s.Substring(x).Equals(query))
                { 
                    peso++;
                    result.Add(query + "Yes");
                }

                else
                {
                    peso = pesoOriginal;
                    result.Add(query + " No");
                }
                    
            }
        }

        return result;
    }
}
