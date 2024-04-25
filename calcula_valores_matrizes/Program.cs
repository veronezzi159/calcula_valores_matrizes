int qtd_linhas = 0,  qtd_colunas = 0, escolha = 0;

void imprimirMatriz(float[,] matriz, string titulo)
{
    Console.WriteLine($"\n {titulo}");
    for (int linhas = 0; linhas < qtd_linhas; linhas++)
    {
        Console.WriteLine();
        for (int colunas = 0; colunas < qtd_colunas; colunas++)
        {
            Console.Write($"{matriz[linhas,colunas]} ");
        }
    }
    Console.WriteLine();
}
void menu()
{
    Console.WriteLine("Escolha qual operação deseja realizar");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("digite qualque numero pra encerrar");
    escolha = int.Parse( Console.ReadLine() );
}
void encerrar()
{
    Console.WriteLine("Obrigado! Encerrando");
    Console.ReadLine();
}

void escolher_dimensoes()
{
    do
    {
        Console.Write("Digite a quantidade de colunas das matrizes: ");
        qtd_colunas = int.Parse(Console.ReadLine());
        Console.Write("\nDigite a quantidade de linhas das matrizes: ");
        qtd_linhas = int.Parse(Console.ReadLine());
    } while (qtd_linhas < 1 && qtd_colunas < 1);
}

void sortear_matriz(float[,] matriz)
{
    for (int linhas= 0; linhas < qtd_linhas; linhas++)
    {
        Console.WriteLine();
        for (int colunas = 0; colunas < qtd_colunas; colunas++)
        {
            matriz[linhas, colunas] = new Random().Next(0, 101);
            Console.WriteLine(matriz[linhas,colunas]);
        }
    }
}
void somar_matrizes(float[,] soma, float[,] matriz1, float[,] matriz2)
{
    for (int linhas = 0; linhas < qtd_linhas; linhas++)
    {
        for (int colunas = 0; colunas < qtd_colunas; colunas++)
        {
            soma[linhas, colunas] = matriz1[linhas, colunas] + matriz2[linhas, colunas];
        }
    }
}
void subtrair_matrizes(float[,] sub, float[,] matriz1, float[,] matriz2)
{
    for (int linhas = 0; linhas < qtd_linhas; linhas++)
    {
        for (int colunas = 0; colunas < qtd_colunas; colunas++)
        {
            sub[linhas, colunas] = matriz1[linhas, colunas] - matriz2[linhas, colunas];
        }
    }
}
void multiplicar_matrizes(float[,] mult, float[,] matriz1, float[,] matriz2)
{
    for (int linhas = 0; linhas < qtd_linhas; linhas++)
    {
        for (int colunas = 0; colunas < qtd_colunas; colunas++)
        {
            mult[linhas, colunas] = matriz1[linhas, colunas] * matriz2[linhas, colunas];
        }
    }
}
void dividir_matrizes(float[,] div, float[,] matriz1, float[,] matriz2)
{
    for (int linhas = 0; linhas < qtd_linhas; linhas++)
    {
        for (int colunas = 0; colunas < qtd_colunas; colunas++)
        {
            if (matriz2[linhas, colunas] != 0)
            {
                div[linhas, colunas] = matriz1[linhas, colunas] / matriz2[linhas, colunas];
            }
            else
            {
                div[linhas, colunas] = float.NaN;
            }
        }
    }
}

menu();
escolher_dimensoes();

float[,] matriz1 = new float[qtd_linhas, qtd_colunas], matriz2 = new float[qtd_linhas, qtd_colunas], matriz_soma = new float[qtd_linhas, qtd_colunas];
float[,] matriz_sub = new float[qtd_linhas, qtd_colunas];
float[,] matriz_div = new float[qtd_linhas, qtd_colunas];
float[,] matriz_mult = new float[qtd_linhas, qtd_colunas];

sortear_matriz(matriz1);
sortear_matriz(matriz2);

imprimirMatriz(matriz1, "Matriz 1");

imprimirMatriz(matriz2, "Matriz 2");

switch (escolha)
{
    case 1: somar_matrizes(matriz_soma, matriz1, matriz2);
            imprimirMatriz(matriz_soma, "Matriz Soma: ");
        break;
    case 2: subtrair_matrizes(matriz_sub, matriz1, matriz2);
            imprimirMatriz(matriz_sub, "Matriz Subtração");
        break;
    case 3: multiplicar_matrizes(matriz_mult, matriz1, matriz2);
            imprimirMatriz(matriz_mult, "Matriz Multiplicada");
        break;
    case 4: dividir_matrizes(matriz_div, matriz1, matriz2);
            imprimirMatriz(matriz_div, "Matriz Dividida");
        break;
    default: encerrar();
        break;
}

