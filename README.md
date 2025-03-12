# JOGO DA FORCA.
O jogo da forca � um jogo em que os jogadores devem adivinhar uma palavra, escolhendo letras, e evitando que o
boneco seja enforcado por atingir um numero maximo de tentativas.
Nesta vers�o, o usuario ter� 5 tentativas para adivinhar as letras que forma a palavra secreta.

## Funcionalidades
	
- **O Jogo funciona no Console.App:**

- **O jogo inicia apresentando o desenho de um forca, e permite que o usuario fa�a chutes tentando acertar a letra da palavra secreta. 

- **A cada erro, as partes do boneco s�o desenhadas na tela.**

- **O boneco ser� completado ao atingir o numero maximo de tentativas(5) resultando em "perdeu".**

- **O Jogo apresentar� uma contagem da quantidade de erros do jogador**
	
- **Sempre que o usuario "ganhar" ou "perder", o jogo mostrar� uma mensagem de acordo ao resultado da partida.**
	
- **Ap�s o final da Partida o usuario ter� como op��o decidir se deseja ou n�o jogar novamente.**


## Instala��o - Como Ultilizar.

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

6. Para execultar o arquivo compliado .exe, navegue at� a pasta 
JogoDaForca.ConsoleApp\bin\Release\net8.0 e execulte o arquivo JogoDaForca.ConsoleApp

# Demo.

![](https://i.imgur.com/l81m6JO.gif)

## Requisitos.

- **.NET SDK (recomendado .NET 8.0 ou superior)**
- **N�o h� restri��es minimo de Memoria Ram ou graficos(VGA/GPU) **