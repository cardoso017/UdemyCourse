using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new jogoFoda(new Jogador("Jõao"), new Jogador1());
            jogo.InciarJogo();
        }
    }


 
}

