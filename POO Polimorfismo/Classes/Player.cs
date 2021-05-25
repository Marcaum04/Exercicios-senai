using System;

namespace POO_Polimorfismo.Classes
{
    public abstract class Player
    {
        private float velocidade;
        private float forcaPulo;

        public virtual string Correr() {
            return "O Player correu";
        }
        public virtual string Pular() {
            return "O Player pulou";
        }
    }
}