namespace JogoDaForca.ConsoleApp
{
    public static class Jogo
    {
        public static string LogicaDoJogo(string palavraEscolhida, char chute, char[] letrasEncontradas, bool letraFoiEncontrada)
        {
           string letraEncontrada = "";

            for (int contCaracter = 0; contCaracter < palavraEscolhida.Length; contCaracter++)
            {
                char caracterAtual = palavraEscolhida[contCaracter];

                if (chute == caracterAtual)
                {
                    letrasEncontradas[contCaracter] = caracterAtual;
                    letraFoiEncontrada = true;
                }
            }
            return letraEncontrada;
        }

        public static string ExibirDesenho( int quantidadeDeErros, char[] letrasEncontradas)
        {
            string desenho = "";

            string cabecaDodesenho = quantidadeDeErros >= 1 ? " o " : " ";
            string troncoDoDesenho = quantidadeDeErros >= 2 ? "x" : " ";
            string troncoInferior = quantidadeDeErros >= 3 ? " x " : " ";
            string bracoEsquerdo = quantidadeDeErros >= 4 ? "/" : " ";
            string bracoDireito = quantidadeDeErros >= 5 ? "\\" : " ";
            string pernasDoDesenho = quantidadeDeErros >= 5 ? "/ \\" : " ";

            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("--------------- Jogo da Forca ---------------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
            Console.WriteLine(" ___________        ");
            Console.WriteLine(" |/        |        ");
            Console.WriteLine(" |        {0}       ", cabecaDodesenho);
            Console.WriteLine(" |        {0}{1}{2} ", bracoEsquerdo, troncoDoDesenho, bracoDireito);
            Console.WriteLine(" |        {0}       ", troncoInferior);
            Console.WriteLine(" |        {0}       ", pernasDoDesenho);
            Console.WriteLine(" |                  ");
            Console.WriteLine(" |                  ");
            Console.WriteLine("_|____              ");
            Console.WriteLine();
            Console.WriteLine("Erros do jogador: " + quantidadeDeErros);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Palavra Secreta: " + String.Join("", letrasEncontradas));
            Console.WriteLine("---------------------------------------------");

            return desenho;
        }
    }
}
