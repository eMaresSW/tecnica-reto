using System;

public class Class1
{
    static void Main(string[] args)
    {
        // Instancia de tu clase
        var solver = new WeightedUniformStringSolver();

        // Cadena de prueba
        string cadena = "abccba";

        // Lista de queries (pesos a verificar)
        List<int> queries = new List<int> { 1, 3, 9, 10 };

        // Llamada al método
        solver.WeightedUniformStrings(cadena, queries);
    }
}
