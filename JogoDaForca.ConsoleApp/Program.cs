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
                    string desenhoDoFoca = Jogo.ExibirDesenho(quantidadeDeErros, letrasEncontradas);

                    Console.Write("Digite uma letra válida: ");
                    string entradaInicial = Console.ReadLine()!.ToUpper();
                    if (entradaInicial.Length > 1)
                    {
                        Console.WriteLine("Informe apenas uma letra.");
                        continue;
                    }

                    // LOGICA DO JOGO.
                    char chute = entradaInicial[0];

                    bool letraFoiEncontrada = Jogo.LogicaDoJogo(palavraEscolhida, chute, letrasEncontradas); 

                    if (letraFoiEncontrada == false)
                        quantidadeDeErros++;

                    string palavraEncontradaCompleta = String.Join("", letrasEncontradas);

                    jogadorGanhou = palavraEscolhida == palavraEncontradaCompleta;
                    jogadorPerdeu = quantidadeDeErros > 5;

                    string resultado = Jogo.Resultado(jogadorGanhou, jogadorPerdeu, palavraEscolhida);

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
