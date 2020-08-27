using GameTOP.Interface;

namespace GameTop.Lib
{
    public class Jogador1 : IJogador
    {
        public string chuta()
        {
             return $"lucas esta correndo";
            
                    }

        public string corre()
        {   
             return $"Lucas esta correndo";
            
                    }

        public string passe()
        {
             return $"Lucas está correndo";
        }
    }
}