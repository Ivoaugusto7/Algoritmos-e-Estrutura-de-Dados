# Contagem de Operações

A contagem de operações é uma técnica fundamental da Análise de Algoritmos utilizada para estimar o custo computacional de um algoritmo, medindo quantas vezes uma operação relevante é executada em função do tamanho da entrada.

Esse método abstrai detalhes de hardware, linguagem e compilador, focando apenas no comportamento assintótico do algoritmo.

## Conceito Fundamental

- O custo total de um algoritmo é dado pela soma do custo de suas operações relevantes.

- Em Algoritmos e Estruturas de Dados, normalmente consideramos como operação relevante:

- Comparações entre elementos

- Atribuições

- Operações aritméticas específicas (dependendo do problema)

- Salvo indicação contrária, a análise considera o pior caso.

## Contagem de Operações em Estruturas Condicionais
### Estrutura *`if-else`*
```
if (condicao) 
{
    listaVerdadeiro();
}
    else 
    {
        listaFalso();
    }
```

**Melhor caso:**
custo(condicao) + min(custo(listaVerdadeiro), custo(listaFalso))

**Pior caso:**
custo(condicao) + max(custo(listaVerdadeiro), custo(listaFalso))

A condição sempre é avaliada, independentemente do ramo executado.

## Contagem de Operações em Estruturas de Repetição
### Estrutura *`while`*
```
while (condicao)
{
    lista();
}
```

**Custo total:**

condicao + n × (lista + condicao)

Onde n é o número de iterações do laço.

## Estrutura *`do-while`*
```
do {
       lista();
   } while (condicao);
```

**Custo total:**

n × (lista + condicao)

Nesse caso, o laço executa ao menos uma vez.

## Estrutura *`for`*
```
for (inicializacao; condicao; incremento)
{
    lista();
}
```

O custo considera:

- Inicialização
- Avaliação da condição
- Execução da lista de comandos
- Incremento

Normalmente, esse custo é simplificado para:

n × (lista + condicao)

## Laços com Redução do Espaço de Busca

Quando o laço reduz sistematicamente o valor de controle pela metade, o custo é logarítmico.

### **Exemplo:**
```
for (int i = n; i > 0; i /= 2)
{
    a *= 2;
}
```

**Número de iterações:** lg(n) + 1

**Complexidade:**

- O(lg n)

- Ω(lg n)

- Θ(lg n)

## Melhor Caso, Pior Caso e Caso Médio

**Melhor caso:** menor custo possível para todas as entradas de tamanho n

**Pior caso:** maior custo possível para todas as entradas de tamanho n

**Caso médio:** média dos custos considerando todas as entradas possíveis

Na ausência de especificação explícita, considera-se o pior caso.

## Função de Complexidade

A função de complexidade expressa o número de execuções da operação relevante em função do tamanho da entrada:

T(n)

### **Exemplo:**

Encontrar o menor elemento em um vetor de n posições:

T(n) = n − 1

## Observações Importantes

### São desconsiderados:

- Custos de entrada e saída

- Overhead de gerenciamento de memória

- O foco está na tendência de crescimento do custo

- Constantes e termos de menor ordem podem ser ignorados na análise assintótica

## Conclusão

A contagem de operações fornece a base para a definição da complexidade de tempo e espaço de algoritmos e para o uso das notações assintóticas O, Ω e Θ, permitindo comparar soluções de forma precisa, independente da linguagem ou do ambiente de execução.
