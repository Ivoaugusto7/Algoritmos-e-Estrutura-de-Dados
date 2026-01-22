# Sucessões de Gols por Recursividade

Dado o placar final de uma partida de futebol entre as equipes A e B (m x n), gerar e imprimir, por recursividade, todas as possíveis sucessões (ordens) em que os gols poderiam ter sido marcados, considerando exatamente m gols de A e n gols de B.

## Regras/Restrições

- Ler dois inteiros não negativos m e n (0 ≤ m, n ≤ 12) representando a quantidade de gols de A e de B, respectivamente.
- A geração deve ser obrigatoriamente recursiva, escolhendo em cada passo marcar um gol de A (se ainda restarem) ou um gol de B (se ainda restarem).
- Cada sucessão deve conter exatamente m + n símbolos.
- Imprimir cada sucessão em uma linha, com as letras separadas por espaço, usando apenas as letras A e B.
- A ordem das linhas deve ser lexicográfica considerando A < B (primeiro ramos com A, depois com B).
- Caso m = 0 ou n = 0, existe apenas uma sucessão (todos A ou todos B).

## Formato de entrada

Uma linha contendo dois inteiros m e n (separados por espaço ou quebra de linha).

## Formato de saída

Várias linhas, cada uma contendo uma sucessão possível no formato: A B A B ..., totalizando C(m+n, m) linhas.
