using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije
{
    internal class Vozilo
    {
        private string model, godina, kotaci, kategorija,dodatak;

        public override string ToString()
        {
            string ispis = this.model + "\t\t" + this.godina + "\t\t\t" + this.kotaci + "\t\t\t" + this.dodatak + "\t\t\t" + this.kategorija;
            return ispis;
        }
        public Vozilo(string model, string godina, string kotaci, string kategorija)
        {
            this.model = model;
            this.godina = godina;
            this.kotaci = kotaci;
            this.kategorija = kategorija;

        }
        public string Model { get => model; set => model = value; }
        public string Godina{ get => godina; set => godina = value; }
        public string Kotaci { get => kotaci; set => kotaci = value; }
        public string Kategorija { get => kotaci; set => kotaci = value; }
        public string Dodatak { get => dodatak; set => dodatak = value; }
    }
}
