using System;

class JogoDaVelha
{
    private char[,] board = new char[3, 3];
    private bool turnoPlayerX = true;
    private bool gameOver = false;

    public JogoDaVelha()
    {
        BoardReset();
    }

    public void Start()
    {
        while (true)
        {
            Console.Clear();
            BoardReset();
            BoardEmpate();
            gameOver = false;

            while (!gameOver)
            {
                JogadaPlayer(turnoPlayerX ? 'X' : 'O');
                Console.Clear();
                BoardEmpate();
                ChecarVencedor();
                turnoPlayerX = !turnoPlayerX;
            }

            Console.WriteLine("Deseja jogar novamente? (S/N)");
            char choice = Console.ReadKey().KeyChar;
            if (char.ToUpper(choice) != 'S')
            {
                break;
            }
        }
    }

    private void BoardReset()
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                board[row, col] = ' ';
            }
        }
    }

    private void BoardEmpate()
    {
        Console.WriteLine("  1 2 3");
        for (int row = 0; row < 3; row++)
        {
            Console.Write(row + 1);
            for (int col = 0; col < 3; col++)
            {
                Console.Write(" " + board[row, col]);
                if (col < 2)
                {
                    Console.Write("|");
                }
            }
            Console.WriteLine();

            if (row < 2)
            {
                Console.WriteLine("  -+-+-");
            }
        }
    }

    private void JogadaPlayer(char playerSymbol)
    {
        Console.WriteLine($"Vez do jogador '{playerSymbol}'. Digite a linha e coluna (por exemplo, 1 2): ");
        string[] input = Console.ReadLine().Split(' ');
        if (input.Length != 2 || !int.TryParse(input[0], out int row) || !int.TryParse(input[1], out int col) ||
            row < 1 || row > 3 || col < 1 || col > 3 || board[row - 1, col - 1] != ' ')
        {
            Console.WriteLine("Jogada inválida. Tente novamente.");
            JogadaPlayer(playerSymbol);
        }
        else
        {
            board[row - 1, col - 1] = playerSymbol;
        }
    }

    private void ChecarVencedor()
    {
        char winner = ' ';
        // Verifica linhas, colunas e diagonais
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
            {
                winner = board[i, 0];
                break;
            }
            if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
            {
                winner = board[0, i];
                break;
            }
        }

        if ((board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) ||
            (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]))
        {
            winner = board[1, 1];
        }

        if (winner == 'X' || winner == 'O')
        {
            Console.WriteLine($"Jogador '{winner}' ganhou! Parabéns!");
            gameOver = true;
        }
        else if (!board.Cast<char>().Any(c => c == ' '))
        {
            Console.WriteLine("Empate! O jogo acabou em empate.");
            gameOver = true;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo ao Jogo da Velha de dois jogadores!");
        JogoDaVelha jogo = new JogoDaVelha();
        jogo.Start();
    }
}
