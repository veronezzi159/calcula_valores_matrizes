int qtd_linhas = 0,  qtd_colunas = 0;

do
{
    Console.Write("Digite a quantidade de colunas das matrizes: ");
    qtd_colunas = int .Parse(Console.ReadLine());
    Console.Write("\nDigite a quantidade de linhas das matrizes: ");
    qtd_linhas = int .Parse(Console.ReadLine());    
} while (qtd_linhas < 1 && qtd_colunas < 1);

int[,] matriz1 = new int[qtd_linhas, qtd_colunas], matriz2 = new int[qtd_linhas, qtd_colunas], matriz_soma = new int[qtd_linhas, qtd_colunas];
int[,] matriz_sub = new int[qtd_linhas, qtd_colunas];
int[,] matriz_div = new int[qtd_linhas, qtd_colunas];
int[,] matriz_mult = new int[qtd_linhas, qtd_colunas];

for (int linhas = 0; linhas < qtd_linhas; linhas++)
{
    for (int colunas = 0;  colunas < qtd_colunas; colunas++)
    {
        matriz1[linhas, colunas] = new Random().Next(0,101);
        matriz2[linhas, colunas] = new Random().Next(0, 101);
        matriz_soma[linhas, colunas] = matriz1[linhas,colunas] + matriz2[linhas,colunas];
        matriz_sub[linhas, colunas] = matriz1[linhas,colunas] - matriz2[linhas,colunas];
        matriz_div[linhas, colunas] = matriz1[linhas,colunas] / matriz2[linhas,colunas];
        matriz_mult[linhas, colunas] = matriz1[linhas,colunas] * matriz2[linhas,colunas];
    }
}

for (int linhas = 0; linhas  < qtd_linhas; linhas++)
{
    Console.WriteLine();
    for (int colunas = 0; colunas < qtd_colunas; colunas++)
    {
        Console.Write($"linha: {linhas} coluna: {colunas}, soma:{ matriz_soma[linhas,colunas]}, subtração: {matriz_sub[linhas,colunas]}, multiplicação: {matriz_mult[linhas, colunas]}, divisão: {matriz_div[linhas,colunas]}\n");
    }
}