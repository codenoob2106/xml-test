using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml_test
{
    class Mensch
    {
        // Eigenschaften
        private string name;
        private int punkte;

        // Konstruktor
        public Mensch()
        {
            name = "Leer";
            punkte = 0;
        }
        public Mensch(string n)
        {
            name = n;
            punkte = 0;
        }
        public Mensch(string n, int p)
        {
            name = n;
            punkte = p;
        }

        // Ausgaben
        public string Name()
        {
            return name;
        }

        public string Punkte()
        {
            return punkte.ToString();
        }

        // Methoden
        public void NeuerName(string nn)
        {
            name = nn;
        }

        public void NeuePunkte(int np)
        {
            punkte += np;
        }
    }
}
