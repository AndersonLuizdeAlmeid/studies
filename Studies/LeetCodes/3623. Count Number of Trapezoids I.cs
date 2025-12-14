namespace Studies.LeetCodes;
public static class _3623
{
    public static int CountTrapezoids()
    {
        int[][] points = [[0, 0], [1, 0], [0, 1], [2, 1]];

        long MOD = 1_000_000_007;

        // 1. O Mapa (Dicionário)
        // Chave (int) = Coordenada Y
        // Valor (int) = Quantidade de pontos nessa altura
        Dictionary<int, int> yCounts = new Dictionary<int, int>();

        foreach (var point in points)
        {
            int y = point[1]; // O enunciado diz que points[i] = [x, y]

            if (!yCounts.ContainsKey(y))
            {
                yCounts[y] = 0;
            }
            yCounts[y]++;
        }

        long totalTrapezoids = 0;
        long acumuladoDeLinhasAnteriores = 0;

        // 2. Iterar sobre os valores do dicionário
        foreach (int count in yCounts.Values)
        {
            // Se tiver menos de 2 pontos, não forma linha, ignora.
            if (count < 2) continue;

            // Fórmula da combinação: n * (n - 1) / 2
            // Usamos (long) para garantir que a multiplicação não estoure o limite do int
            long linhasNesteNivel = ((long)count * (count - 1)) / 2;

            // 3. O Cálculo Acumulado (Matemática Combinatória)
            // Multiplicamos as linhas de AGORA pelas linhas ACUMULADAS antes
            // (Base Superior * Base Inferior)
            long novasCombinacoes = (linhasNesteNivel * acumuladoDeLinhasAnteriores) % MOD;

            // Adiciona ao total
            totalTrapezoids = (totalTrapezoids + novasCombinacoes) % MOD;

            // Adiciona as linhas atuais ao acumulado para as próximas iterações
            acumuladoDeLinhasAnteriores = (acumuladoDeLinhasAnteriores + linhasNesteNivel) % MOD;
        }

        // Convertemos de volta para int conforme a assinatura do método pede
        return (int)totalTrapezoids;
    }
}