namespace Studies.LeetCodes;
public class _2872
{
    private int _componentCount;
    public  int MaxKDivisibleComponents()
    {
        int n = 5;
        int[][] edges = [[0, 2], [1, 2], [1, 3], [2, 4]];
        int[] values = [1, 8, 1, 4, 4];
        int k = 6;

        List<int>[] adj = new List<int>[n];
        for (int i = 0; i < n; i++)
        {
            adj[i] = new List<int>();
        }

        foreach (var edge in edges)
        {
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]); // Como é não-direcionado, vai e volta
        }
        Dfs(0, -1, adj, values, k);
        return _componentCount;
    }

    private long Dfs(int currentNode, int parentNode, List<int>[] adj, int[] values, int k)
    {
        // Começamos a soma com o valor do próprio nó
        long currentSum = values[currentNode];

        // Para cada vizinho deste nó...
        foreach (var neighbor in adj[currentNode])
        {
            // Importante: Não volte para o pai (de onde você veio)!
            if (neighbor != parentNode)
            {
                // Mergulhe no filho e pegue o que ele retornar
                currentSum += Dfs(neighbor, currentNode, adj, values, k);
            }
        }

        // Verificamos se a soma acumulada até aqui é divisível por k
        if (currentSum % k == 0)
        {
            _componentCount++; // Oba! Achamos um componente válido. Corta!
            return 0;          // Retornamos 0 para o pai, pois essa parte já se resolveu.
        }

        // Se não for divisível, retornamos a soma para o pai tentar resolver junto com o valor dele.
        return currentSum;
    }
}