# JOGO DA FORCA.
O jogo da forca é um jogo em que os jogadores devem adivinhar uma palavra, escolhendo letras, e evitando que o
boneco seja enforcado por atingir um numero maximo de tentativas.
Nesta versão, o usuario terá 5 tentativas para adivinhar as letras que forma a palavra secreta.

## Funcionalidades
	
- **O Jogo funciona no Console.App:**

- **O jogo inicia apresentando o desenho de um forca, e permite que o usuario faça chutes tentando acertar a letra da palavra secreta. 

- **A cada erro, as partes do boneco são desenhadas na tela.**

- **O boneco será completado ao atingir o numero maximo de tentativas(5) resultando em "perdeu".**

- **O Jogo apresentará uma contagem da quantidade de erros do jogador**
	
- **Sempre que o usuario "ganhar" ou "perder", o jogo mostrará uma mensagem de acordo ao resultado da partida.**
	
- **Após o final da Partida o usuario terá como opção decidir se deseja ou não jogar novamente.**


## Instalação - Como Ultilizar.

1. Clone o repositorio ou baixe o codigo fonte do projeto

2. Abra o Terminal ou Prompt de Comando na pasta onde o jogo foi clonado ou baixado.

3. Ultilize o comando abaixo para restaurar as dependencias do projeto.

```
doenet restore
```

4. Para Compilar o projeto ultilize o comando:

```
dotnet build --Configuration Release
```

5. Para execultar o projeto compilando em tempo real

```
doenet run --project JogoDaFoca.ConsoleApp
```

6. Para execultar o arquivo compliado .exe, navegue até a pasta 
JogoDaForca.ConsoleApp\bin\Release\net8.0 e execulte o arquivo JogoDaForca.ConsoleApp

# Demo.

![](https://i.imgur.com/l81m6JO.gif)

## Requisitos.

- **.NET SDK (recomendado .NET 8.0 ou superior)**
- **Não há restrições minimo de Memoria Ram ou graficos(VGA/GPU) **