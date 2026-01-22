# Palíndromo Recursivo

Escreva um programa que leia uma linha de texto e determine se ela é um **palíndromo** utilizando **função recursiva**.

## Definição

Um palíndromo é uma sequência que pode ser lida da mesma forma da esquerda para a direita e da direita para a esquerda, **após aplicar as regras abaixo**.

## Regras

- Desconsidere espaços e quaisquer caracteres que **não sejam letras ou dígitos**
- A verificação é **case-insensitive** (não diferencia maiúsculas de minúsculas)
- A função de verificação deve ser **exclusivamente recursiva**
- Utilize **dois índices** (esquerda e direita) que avançam/retrocedem recursivamente
- Caracteres não alfanuméricos devem ser ignorados durante a verificação
- Se a string resultante for vazia, considere-a **palíndromo**

⚠️ **Importante:**  
Não utilize estruturas de repetição (`for`, `while`) na função que realiza a verificação.

## Entrada

Uma linha de texto (pode conter espaços, números e pontuação).

## Saída

Imprima:

- `SIM` — se o texto for um palíndromo  
- `NAO` — caso contrário
