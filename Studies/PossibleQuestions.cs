/*
 1. 📈 Big O, Complexidade e Trade-offs
Pergunta direta: "O que é a notação Big O?" (What is Big O notation?)

Pergunta de análise: "Se eu tenho um loop for dentro de outro loop for, qual é a complexidade de tempo?"

Follow-up (continuação): "E se o loop interno só percorrer os itens depois do loop externo (ex: j = i + 1)? Muda alguma coisa?" (Resposta: Continua O(n²), não O(n²/2)).

Pergunta de comparação: "Por favor, explique a diferença entre O(1), O(n), O(log n) e O(n log n). Pode me dar um exemplo de algoritmo para cada um?"

Pergunta de trade-off (A mais clássica): "O que é um 'time-space trade-off'? Pode me dar um exemplo claro?" (Exemplo: Usar um Hash Map (O(n) de espaço) para encontrar duplicatas em um array em tempo O(n), em vez de comparar todos com todos em tempo O(n²) e espaço O(1)).

Pergunta de implementação: "Você tem uma função com duas etapas independentes. A primeira é O(n) e a segunda é O(log n). Qual a complexidade total?" (Resposta: O(n), pois você pega o termo dominante).

2. 🏗️ Estruturas de Dados (O Essencial)
Arrays vs. Linked Lists
"Qual é a principal diferença entre um Array e uma Linked List?"

"Quais são os prós e contras de usar um Array em vez de uma Linked List?"

"Qual é a complexidade (Big O) para inserir um item no início de um Array? E em uma Linked List?"

"Quando você definitivamente preferiria usar uma Linked List?" (Ex: Você precisa de muitas inserções/remoções no meio e não precisa de acesso aleatório).

"O que é uma Doubly Linked List (Lista Duplamente Ligada) e por que ela é útil?"

Dictionaries (Hash Maps / Hash Tables)
Pergunta de implementação (Obrigatória): "Como um Hash Map funciona 'por baixo dos panos'?" (Esperam que você fale de um Array, uma Função de Hashing e tratamento de Colisões).

"O que é uma 'colisão' em um Hash Map?"

"Como podemos lidar com colisões?" (Esperam que você fale de Separate Chaining ou Open Addressing).

"Qual é a complexidade de tempo para inserção e busca em um Hash Map? E qual é o pior caso (worst-case)?"

"O que acontece se sua função de hashing for muito ruim e todas as chaves caírem no mesmo índice?"

Stacks e Queues (Pilhas e Filas)
"Qual é a diferença entre LIFO e FIFO? Qual estrutura implementa qual?"

"Como você poderia implementar uma Stack (Pilha)?" (Respostas: Usando um Array Dinâmico ou uma Linked List).

"Me dê um exemplo do mundo real onde você usaria uma Stack." (Ex: Botão "Voltar" do navegador, call stack de funções).

"Me dê um exemplo do mundo real onde você usaria uma Queue." (Ex: Fila de impressão, requisições em um servidor).

Pergunta de quebra-cabeça (Clássica): "Como você implementaria uma Queue usando apenas duas Stacks?"

Sets
"Qual é o propósito de um Set?" (Armazenar valores únicos).

"Como um HashSet é tipicamente implementado?" (Resposta: Usando um Hash Map, onde a chave é o item e o valor é um dummy/irrelevante).

"Qual é a diferença entre um HashSet e um TreeSet (ou um Set ordenado)?" (Resposta: Implementação - Hash Map vs. Árvore Binária de Busca; e Big O - O(1) vs. O(log n)).

3. 🧠 Algoritmos e Técnicas
Sorting (Ordenação)
"Por favor, explique como o Merge Sort funciona." (Eles querem ouvir "Divide and Conquer").

"Por favor, explique como o Quick Sort funciona." (Eles querem ouvir "Pivô" e "Particionamento").

"Qual a diferença de complexidade (melhor, médio, pior caso) entre Merge Sort e Quick Sort?"

"Por que o Quick Sort é tão usado na prática, mesmo tendo um pior caso de O(n²)?" (Resposta: É in-place - usa espaço O(log n) - e na média é muito rápido).

"O que significa um algoritmo de ordenação ser 'estável' (stable)?"

Recursion vs. Iteration
"O que é recursão?"

"Quais são as vantagens e desvantagens de usar recursão em vez de iteração (loops)?"

"Qual é o principal risco ao usar recursão?" (Stack Overflow).

"Todo algoritmo recursivo pode ser reescrito de forma iterativa?" (Sim. Às vezes usando uma Stack explícita).

Divide and Conquer
"Pode me explicar a estratégia 'Dividir e Conquistar'?"

"Além do Merge Sort, que outro algoritmo famoso usa 'Dividir e Conquistar'?" (Binary Search / Busca Binária).

Pergunta de código (mental): "Como você implementaria uma Busca Binária (Binary Search)?"

String Manipulation
"O que significa dizer que Strings são 'imutáveis' (immutable) em linguagens como Java ou Python?"

"Quais são as implicações de performance da imutabilidade de strings?" (Ex: Concatenar 1000 strings em um loop).

"Como você faria para reverter uma string 'in-place' (sem criar uma nova string, se a linguagem permitir)?"

Problema clássico: "Como você verificaria se duas strings são anagramas?"

Solução 1 (Nível bom): Ordenar as duas e comparar (O(n log n)).

Solução 2 (Nível ótimo): Usar um Hash Map / Array de contagem de caracteres (O(n)).

4. 🎓 Tópicos Avançados
Amortized Analysis
Pergunta direta: "Você pode me explicar o que é Análise Amortizada? Não precisa ser uma definição de livro, mas a intuição."

O Exemplo: "Adicionar um item a um Array Dinâmico (como um ArrayList em Java) é às vezes O(n). Por que então dizemos que é O(1) amortizado?"

"Você consegue pensar em outra estrutura de dados onde o custo amortizado é importante?" (Hash Maps, quando ocorre rehashing).

🔥 Dica de Ouro (Pro-Tip)
Para cada pergunta, tente estruturar sua resposta (em inglês):

A Resposta Direta: "A direct answer to your question is..." (Dê a resposta curta).

A Explicação: "This is because..." (Explique como funciona).

Os Trade-offs: "The trade-off, however, is..." (Diga o pró e o contra).

Um Exemplo: "A good example of this is..." (Dê um caso de uso).

Exemplo: "Qual a diferença entre Array e Linked List?"

"[1] The direct difference is how they are stored in memory. Arrays use a contiguous block of memory, while Linked Lists use nodes with pointers. [2] This means Arrays have excellent O(1) (constant time) access by index, but insertions or deletions are slow (O(n)) because you have to shift elements. [3] Linked Lists are the opposite: access is slow (O(n)) because you must traverse the list, but insertions/deletions are very fast (O(1)) if you already have a pointer to the node. [4] So, I would use an Array if I need to read data frequently by index, but a Linked List if I am constantly inserting and deleting items in the middle of the structure."
 */