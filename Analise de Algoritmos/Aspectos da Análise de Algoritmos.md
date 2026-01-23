# Aspectos da análise de algoritmos
## Tipos de Análise de Complexidade

- **Análise de um algoritmo particular**: analisamos o custo de um algoritmo  
  específico para um problema específico.

- **Análise de uma classe de algoritmos**: analisamos o **menor custo possível**  
  para resolver um problema específico.
  - Limite da família de algoritmos
  - Nível mínimo de dificuldade para o problema ser resolvido

---

## Como Medir o Custo de um Algoritmo

O custo de execução de um algoritmo pode variar de acordo com diversos fatores externos, tais como:

- Hardware
- Arquitetura
- Sistema Operacional
- Compilador
- Linguagem de programação

Esses fatores tornam inadequada a medição do custo baseada apenas em tempo real de execução.

---

## Restrições no Modelo do Cronômetro

A medição direta do tempo de execução (cronômetro) não é confiável para análise teórica de algoritmos, pois depende fortemente do ambiente de execução.

---

## Exemplo de Otimização do Compilador

```c
for (int i = 0; i < 20; i++) 
{
    array[i] = i;
}
```

## Tipos de Análise de Complexidade

- **Análise de um algoritmo particular**: analisamos o custo de um algoritmo  
  específico para um problema específico.

- **Análise de uma classe de algoritmos**: analisamos o **menor custo possível**  
  para resolver um problema específico.
  - Limite da família de algoritmos
  - Nível mínimo de dificuldade para o problema ser resolvido

---

## Como Medir o Custo de um Algoritmo

O custo de execução de um algoritmo pode variar de acordo com diversos fatores externos, tais como:

- Hardware
- Arquitetura
- Sistema Operacional
- Compilador
- Linguagem de programação

Esses fatores tornam inadequada a medição do custo baseada apenas em tempo real de execução.

---

## Restrições no Modelo do Cronômetro

A medição direta do tempo de execução (cronômetro) não é confiável para análise teórica de algoritmos, pois depende fortemente do ambiente de execução.

---

## Exemplo de Otimização do Compilador

```c
for (int i = 0; i < 20; i++)
{
    array[i] = i;
}
```

É equivalente a:

```
array[0] = 0;
array[1] = 1;
...
array[19] = 19;
```

## Observações

- Frequentemente, alunos realizam otimizações desnecessárias em termos de eficiência.

- Em muitos casos, o compilador gera o mesmo código objeto para:

  - `if-else-if` e `switch-case`

  - `for` e `while`

- Outras estruturas equivalentes

## Ainda sobre Otimização de Compiladores

Nem toda alteração no código-fonte resulta em melhoria real de desempenho, pois o compilador pode otimizar automaticamente diferentes estruturas para o mesmo código de máquina.

## Modelo Matemático para Medir o Custo de um Algoritmo

Para uma análise confiável, utilizamos um modelo matemático, baseado na contagem de operações.

### Princípios do Modelo

- Determinamos e contamos as operações relevantes

- Em Algoritmos e Estruturas de Dados, geralmente:

- Comparações entre registros (elementos do array)

- O custo total de um algoritmo é a soma do custo de suas operações

### Desconsideramos:

- Sobrecargas de gerenciamento de memória

- Custos de entrada e saída (E/S)

- Salvo indicação contrária, consideramos o pior caso

- É necessário definir a função de complexidade
