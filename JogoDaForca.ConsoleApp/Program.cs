namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool jogarNovamente = true;
            while(jogarNovamente == true)
            {
                string[] palavras = {
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "ABACATE",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUACU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MACA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
                };

                Random geradordeNumeros = new Random();

                int indiceEscolhido = geradordeNumeros.Next(palavras.Length);

                string palavraEscolhida = palavras[indiceEscolhido];

                char[] letrasEncontradas = new char[palavraEscolhida.Length];

                for (int caractereAtual = 0; caractereAtual < letrasEncontradas.Length; caractereAtual++)
                {
                    letrasEncontradas[caractereAtual] = '_';
                }

                int quantidadeDeErros = 0;
                bool jogadorGanhou = false;
                bool jogadorPerdeu = false;

                do
                {
                    // operador ternario
                    // atribui valor a uma variavel dada uma condição.
                    string cabecaDodesenho = quantidadeDeErros >= 1 ? " o " : " ";
                    string trondoDoDesenho = quantidadeDeErros >= 2 ? "x" : " ";
                    string trondoInferior = quantidadeDeErros >= 3 ? " x " : " ";
                    string bracoEsquerdo = quantidadeDeErros >= 4 ? "/" : " ";
                    string bracodireito = quantidadeDeErros >= 5 ? "\\" : " ";
                    string pernasDoDesenho = quantidadeDeErros >= 5 ? "/ \\" : " ";

                    Console.Clear();
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("--------------- Jogo da Forca ---------------");
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine(" ___________        ");
                    Console.WriteLine(" |/        |        ");
                    Console.WriteLine(" |        {0}       ", cabecaDodesenho);
                    Console.WriteLine(" |        {0}{1}{2} ", bracoEsquerdo, trondoDoDesenho, bracodireito);
                    Console.WriteLine(" |        {0}       ", trondoInferior);
                    Console.WriteLine(" |        {0}       ", pernasDoDesenho);
                    Console.WriteLine(" |                  ");
                    Console.WriteLine(" |                  ");
                    Console.WriteLine("_|____              ");
                    Console.WriteLine();
                    Console.WriteLine("Erros do jogador: " + quantidadeDeErros);
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Palavra Secreta: " + String.Join("", letrasEncontradas));
                    Console.WriteLine("---------------------------------------------");

                    Console.Write("Digite uma letra válida: ");
                    string entradaInicial = Console.ReadLine()!.ToUpper();
                    if (entradaInicial.Length > 1)
                    {
                        Console.WriteLine("Informe apenas uma letra.");
                        continue;
                    }

                    // LOGICA DO JOGO.
                    char chute = entradaInicial[0];

                    bool letrasFoiEncontradas = false;

                    for (int contCaracter = 0; contCaracter < palavraEscolhida.Length; contCaracter++)
                    {
                        char caracterAtual = palavraEscolhida[contCaracter];

                        if (chute == caracterAtual)
                        {
                            letrasEncontradas[contCaracter] = caracterAtual;
                            letrasFoiEncontradas = true;
                        }
                    }

                    if (letrasFoiEncontradas == false)
                        quantidadeDeErros++;


                    string palavraEncontradaCompleta = String.Join("", letrasEncontradas);

                    jogadorGanhou = palavraEscolhida == palavraEncontradaCompleta;
                    jogadorPerdeu = quantidadeDeErros > 5;

                    if (jogadorGanhou)
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine($"Você acertou a palavra {palavraEscolhida}");
                        Console.WriteLine("---------------------------------------------");
                    }
                    else if (jogadorPerdeu)
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine($"Que pena, você perdeu!");
                        Console.WriteLine("---------------------------------------------");
                    }


                } while (jogadorGanhou == false && jogadorPerdeu == false);



                Console.Write("Deseja Jogar novamente? S/N ");
                string jogarNovamenteString = Console.ReadLine().ToUpper();
                char jogarNovamenteChar = jogarNovamenteString[0];
                if (jogarNovamenteChar != 'S')
                    jogarNovamente = false;
            }


          

        }
    }
}
