# Funções de Complexidade

## **Função de Complexidade de Tempo**

A função de complexidade de tempo mede o tempo de execução de um algoritmo por meio do **número de execuções da operação relevante**, considerando um problema de tamanho **n**.

## **Função de Complexidade de Espaço**

A função de complexidade de espaço mede a quantidade de memória necessária para executar um algoritmo de tamanho **n**.

---

# Algumas Funções de Complexidade

As funções de complexidade descrevem como o custo de um algoritmo cresce à medida que o tamanho da entrada aumenta, permitindo comparar algoritmos de forma abstrata.

---

# Cálculo de Complexidade para Estruturas Condicionais

Em uma estrutura condicional, o custo total será o custo da condição somado ao custo do bloco executado.

### Estrutura `if-else`

```c
if (condicao()) {
    listaVerdadeiro();
} else {
    listaFalso();
}
```
**Melhor caso:**

condicao() + mínimo(listaVerdadeiro(), listaFalso())

**Pior caso:**

condicao() + máximo(listaVerdadeiro(), listaFalso())
Cálculo de Complexidade para Estruturas de Repetição
Em estruturas de repetição, o custo é dado pelo custo da condição somado ao número de iterações multiplicado pelo custo do corpo do laço.

### Estrutura `while`
```c
while (condicao()) 
{
    lista();
}
```
**Custo total:**

condicao() + n × (lista() + condicao())
onde n é o número de vezes que o laço será repetido.

## Observações Importantes
Para outros laços, considera-se sempre o limite superior do número de iterações.

Para métodos, considera-se o custo do método.

Para métodos recursivos, utilizam-se equações de recorrência
(assunto relacionado à Teoria dos Grafos e Computabilidade).

# Cálculo de Complexidade
Um algoritmo ótimo é aquele cujo custo é igual ao menor custo possível para resolver um determinado problema.
