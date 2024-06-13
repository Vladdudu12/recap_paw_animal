using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recapitulare_Paw_Animal
{
    [Serializable] //ca avem scriere si citire fisier binar
    public class Animal:ICalculVarsta //ca sa implementam interfata creata
    {

        private string id;
        private string denumire;
        private DateTime dataNastere;
        private string habitat;
        private float inaltime;

        public Animal(string id = "-", string denumire = "-", DateTime dataNastere = new DateTime(), string habitat = "-", float inaltime = 0)
        {
            this.id = id;
            this.denumire = denumire;
            this.dataNastere = dataNastere;
            this.habitat = habitat;
            this.inaltime = inaltime;
        }

        public string Id { get => id; set => id = value; }
        public string Denumire { get => denumire; set => denumire = value; }
        public DateTime DataNastere { get => dataNastere; set => dataNastere = value; }
        public string Habitat { get => habitat; set => habitat = value; }
        public float Inaltime { get => inaltime; set => inaltime = value; }

        public int varstaAnimal()
        {
            int varstaAnimal = 0;
            varstaAnimal = DateTime.Now.Year - this.DataNastere.Year;
            return varstaAnimal;
        }
    }
}
