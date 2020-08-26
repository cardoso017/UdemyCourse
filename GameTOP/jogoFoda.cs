using System;
using GameTOP;

class jogoFoda{
        private readonly IJogador _jogador;

        private readonly IJogador _jogador2;
        public jogoFoda(IJogador jogador, IJogador jogador2){
            _jogador = jogador;
            _jogador2 = jogador2;

        }
        public void InciarJogo(){
           Console.WriteLine(_jogador.corre());
          Console.WriteLine(_jogador.chuta());
          Console.WriteLine(_jogador.passe());

          Console.WriteLine(_jogador2.corre());
          Console.WriteLine(_jogador2.chuta());
          Console.WriteLine(_jogador2.passe());  
               }
    }
    