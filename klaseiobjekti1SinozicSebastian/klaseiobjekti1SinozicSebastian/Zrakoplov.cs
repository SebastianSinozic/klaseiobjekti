using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klaseiobjekti1SinozicSebastian
{
    class Zrakoplov
    {

        private string naziv;
        private int snagaMotora;
        private int dosegLeta;


        public Zrakoplov()
        {

        }
        public Zrakoplov(string naziv, int snagaMotora,int dosegLeta)
            {
            this.naziv=naziv;
            this.snagaMotora=snagaMotora;
            this.dosegLeta=dosegLeta; 
            }
        public Zrakoplov(string naziv, int snagaMotora)
        {
            this.naziv = naziv;
            this.snagaMotora = snagaMotora;
        }

        public string getNaziv()
        {
            return naziv;
        }

        public void setNaziv(string naziv)
        {
            this.naziv = naziv;
        }
        public int getSnagaMotora() { 
            return snagaMotora;
        }
        public void setSnagaMotora(int snagaMotora)
        {
            this.snagaMotora = snagaMotora;
        }
        public int getDosegLeta()
        {
            return dosegLeta;
        }
        public void setDosegLeta(int dosegLeta)
        {
            this.dosegLeta = dosegLeta;
        }

    }
}
