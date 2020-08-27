using System;
using GameTOP.Interface;

namespace GameTop.Lib
{
    public class Jogador : IJogador
    {
        public string _Nome { get; set; }
 public Jogador(string nome){
     _Nome = nome;
}


        public string chuta(){
            return $"{_Nome} esta chutando";
        }


        public string corre(){
            return $"{_Nome} esta correndo";
        }

        public string passe(){
            return $"{_Nome} esta dando passe";

        }
    }
}