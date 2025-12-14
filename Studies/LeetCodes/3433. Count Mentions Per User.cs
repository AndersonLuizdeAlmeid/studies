namespace Studies.LeetCodes;
public static class _3433
{
    public static int[] CountMentionsPerUser()
    {
        int numberOfUsers = 2;
        IList<IList<string>> events = [["MESSAGE", "10", "id1 id0"], ["OFFLINE", "11", "0"], ["MESSAGE", "71", "HERE"]];
        // Array para armazenar o resultado final
        int[] mentions = new int[numberOfUsers];

        // Array para rastrear quando o usuário estará online novamente.
        // Se onlineTime[i] <= tempoAtual, o usuário está online.
        int[] onlineTime = new int[numberOfUsers];

        // Precisamos de uma lista estruturada para poder ordenar corretamente
        List<EventInfo> sortedEvents = new List<EventInfo>();

        foreach (var e in events)
        {
            sortedEvents.Add(new EventInfo
            {
                Type = e[0],
                Timestamp = int.Parse(e[1]),
                Data = e[2]
            });
        }

        // Ordenação Personalizada:
        // 1. Pelo Timestamp (crescente)
        // 2. Pelo Tipo: OFFLINE deve vir antes de MESSAGE se os tempos forem iguais
        //    (para garantir que o status mude antes da mensagem ser processada)
        sortedEvents.Sort((a, b) =>
        {
            if (a.Timestamp != b.Timestamp)
            {
                return a.Timestamp.CompareTo(b.Timestamp);
            }
            // Se tempos iguais: "OFFLINE" (prioridade) vs "MESSAGE".
            // Vamos considerar OFFLINE como menor valor para vir primeiro.
            bool aIsOffline = a.Type == "OFFLINE";
            bool bIsOffline = b.Type == "OFFLINE";

            if (aIsOffline && !bIsOffline) return -1;
            if (!aIsOffline && bIsOffline) return 1;
            return 0;
        });

        // Processamento dos eventos
        foreach (var evt in sortedEvents)
        {
            if (evt.Type == "OFFLINE")
            {
                // Evento OFFLINE: Marca o usuário como offline até T + 60
                int userId = int.Parse(evt.Data);
                onlineTime[userId] = evt.Timestamp + 60;
            }
            else
            {
                // Evento MESSAGE
                if (evt.Data == "ALL")
                {
                    // Menciona todos, independente do status
                    for (int i = 0; i < numberOfUsers; i++)
                    {
                        mentions[i]++;
                    }
                }
                else if (evt.Data == "HERE")
                {
                    // Menciona apenas quem está online
                    for (int i = 0; i < numberOfUsers; i++)
                    {
                        // Verifica se o usuário já voltou a ficar online ou nunca saiu
                        if (evt.Timestamp >= onlineTime[i])
                        {
                            mentions[i]++;
                        }
                    }
                }
                else
                {
                    // Lista de IDs específicos (ex: "id0 id1 id0")
                    string[] ids = evt.Data.Split(' ');
                    foreach (var token in ids)
                    {
                        // O token vem no formato "id<numero>", removemos o "id"
                        // Usamos Substring(2) para pular os caracteres 'i' e 'd'
                        int userId = int.Parse(token.Substring(2));
                        mentions[userId]++;
                    }
                }
            }
        }

        return mentions;
    }

    // Classe auxiliar para organizar os dados antes da ordenação
    private class EventInfo
    {
        public string Type { get; set; }
        public int Timestamp { get; set; }
        public string Data { get; set; }

    }
}