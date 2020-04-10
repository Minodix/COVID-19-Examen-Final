using System;
using System.Collections.Generic;
using System.Text;

namespace COVID19
{
    public class Registro
    {
        private string provincia;
        private int cantCasos;
        private int cantFallecidos;
        private int cantRecuperados;


        public int CantCasos { get => cantCasos; set => cantCasos = value; }
        public int CantFallecidos { get => cantFallecidos; set => cantFallecidos = value; }
        public int CantRecuperados { get => cantRecuperados; set => cantRecuperados = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public DateTime date { get; set; }
    }
}
