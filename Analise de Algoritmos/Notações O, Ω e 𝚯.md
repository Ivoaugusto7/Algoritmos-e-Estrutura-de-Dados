# **Notações Assintóticas: O, Ω e Θ**

As notações assintóticas são utilizadas para descrever o comportamento do custo de um algoritmo à medida que o tamanho da entrada cresce, ignorando constantes e termos de menor ordem.

---

## Notação O (Big-O)

A notação O representa o **limite superior** da função de complexidade de um algoritmo.

Ela indica o pior caso, ou seja, o máximo de operações que o algoritmo pode executar para uma entrada de tamanho n.

### Definição:

Um algoritmo possui complexidade **O(f(n))** se existir uma constante **c > 0** e um valor **n₀** tal que:

T(n) ≤ c · f(n), para todo n ≥ n₀


### Exemplo:

- Um algoritmo com custo `3n + 5` é **O(n)**
- Um algoritmo com custo `n² + 10n + 20` é **O(n²)**

---

## Notação Ω (Ômega)

A notação Ω representa o **limite inferior** da função de complexidade.

Ela indica o melhor caso, ou o menor custo possível que um algoritmo terá para uma entrada de tamanho **n**.

### Definição:

Um algoritmo possui complexidade **Ω(f(n))** se existir uma constante **c > 0** e um valor **n₀** tal que:

T(n) ≥ c · f(n), para todo n ≥ n₀


### Exemplo:

- Um algoritmo que sempre executa pelo menos `n` operações é **Ω(n)**
- Um algoritmo que executa no mínimo `n log n` operações é **Ω(n log n)**

---

## Notação Θ (Theta)

A **notação Θ** representa um **limite exato** da função de complexidade.

Ela é utilizada quando o algoritmo possui limite superior e inferior iguais, caracterizando um crescimento bem definido.

### Definição:

Um algoritmo possui complexidade **Θ(f(n))** se existir constantes **c₁ > 0**, **c₂ > 0** e **n₀** tais que:

c₁ · f(n) ≤ T(n) ≤ c₂ · f(n), para todo n ≥ n₀


### Exemplo:

- Um algoritmo com custo `2n + 10` é **Θ(n)**
- Um algoritmo com custo `5n² + 3n + 1` é **Θ(n²)**

---

## Resumo das Notações

| Notação | Representa | Interpretação |
|---------|------------|---------------|
| **O(f(n))** | Limite superior | Pior caso |
| **Ω(f(n))** | Limite inferior | Melhor caso |
| **Θ(f(n))** | Limite exato | Crescimento real |

---
