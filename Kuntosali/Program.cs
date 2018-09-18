using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuntosali
{
    // Määritetään luokka Asiakas
    class Asiakas
    {
        // Asiakkaan attribuutit (ominaisuudet)
        string etunimi;
        string sukunimi;
        uint ika;
        bool mies;
        double pituus;
        double paino;

        // Olionmuodostin (konstruktori)
        public Asiakas(string etunimi, string sukunimi, uint ika, bool mies, double pituus, double paino)
        {
            this.etunimi = etunimi;
            this.sukunimi = sukunimi;
            this.ika = ika;
            this.mies = mies;
            this.pituus = pituus;
            this.paino = paino;
        }

        //Metodi, jolla lasketaan painoindeksi
        public void LaskeBMI()
        {
            double bmi = this.paino / (this.pituus * this.pituus);
            Console.WriteLine("Asiakkaan BMI on: " + bmi);
        }
        // Metodi tietojen tulostamiseen ruudulle
        public void TulostaHenkilötiedot()
        {
            Console.WriteLine("Asiakkaan etunimi on " + etunimi + ", sukunimi on " + sukunimi + " ja ikä on " + ika + " on mies " + mies);
        }

        // Metodit rasvaprosentin laskemiseen

        // Pojan rasvaprosentti
        public void PojanRasvaProsentti()
        {
            double bmi = this.paino / (this.pituus * this.pituus);
            double rasvaProsentti = (1.51f * bmi) - (0.70f * this.ika) - 3.6f + 1.4f;
            Console.WriteLine("Rasvaprosentti on: " + rasvaProsentti);
        }

    }
    class Program
    {
        // Varsinainen ohjelma alkaa tästä
        static void Main(string[] args)
        {
            // Käyttöliittymän muuttujat
            string eNimi;
            string sNimi;
            string asIka;
            string onMies;
            string asPaino;
            string asPituus;
            double paino;
            double pituus;
            bool mies;
            uint ika;

            // Kysytään käyttäjältä asiakastiedot
            Console.Write("Anna etunimi: ");
            eNimi = Console.ReadLine();
            Console.Write("Anna sukunimi: ");
            sNimi = Console.ReadLine();
            Console.Write("Anna ikä: ");
            asIka = Console.ReadLine();
            Console.Write("Anna paino: ");
            asPaino = Console.ReadLine();
            Console.Write("Anna pituus: ");
            asPituus = Console.ReadLine();
            Console.Write("Paina X, jos asiakas on Mies ");
            onMies = Console.ReadLine();

            // Muutetaan tekstinä annetut tiedot luvuiksi
            ika = UInt32.Parse(asIka); // Muunnos 32 bittiseksi parse-metodilla
            paino = Double.Parse(asPaino); // Muunnos kaksoistarkkuuden liukuluvuksi
            pituus = Double.Parse(asPituus);

            // Tutkitaan onko käyttäjä painanut x-näppäintä
            if (onMies == "x")
            {
                mies = true;
            }
            else
            {
                mies = false;
            }
            // Luodaan asiakas käyttäjän antamien tietojen perusteella
            Asiakas asiakas1 = new Asiakas(eNimi,sNimi,ika,mies, pituus, paino);
            Console.WriteLine("Asiakkaan 1 tiedot ovat:");
            asiakas1.TulostaHenkilötiedot();
            asiakas1.LaskeBMI();
            Console.ReadLine();
        }
    }
}
