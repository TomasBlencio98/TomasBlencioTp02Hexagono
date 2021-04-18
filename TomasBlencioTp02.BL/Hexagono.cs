using System;

namespace TomasBlencioTp02.BL
{
    public class Hexagono
    {
        //Atributos
        public double Lado { get; set; }
        public string Borde { get; set; }

        #region Constructores
        public Hexagono()
        {

        }
        public Hexagono(double lado)
        {
            Lado = lado;
        }
        #endregion

        //Metodos
        public double GetApotema()
        {
            return Math.Sqrt(Math.Pow(Lado, 2) - Math.Pow(Lado / 2, 2));
        }

        public double GetPerimetro()
        {
            return Lado * 6;
        }

        public double GetArea()
        {
            return (Lado * 6) * Math.Sqrt(Math.Pow(Lado, 2) - Math.Pow(Lado / 2, 2)) / 2;
        }

    }
}
