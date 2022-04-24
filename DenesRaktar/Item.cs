using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenesRaktar
{
    public class Elem
    {
        public Elem(string _cikkszam, string _nev, int _mennyiseg, int _egysegar, int _osszeg, int _afa, int _ertek, string _szamla)
        {
            cikkszam = _cikkszam;
            nev = _nev;
            mennyiseg = _mennyiseg;
            egysegar = _egysegar;
            osszeg = _osszeg;
            afa = _afa;
            ertek = _ertek;
            szamla = _szamla;
        }
        public string cikkszam;
        public string nev;
        public int mennyiseg;
        public int egysegar;
        public int osszeg;
        public int afa;
        public int ertek;
        public string szamla;
    }
}
