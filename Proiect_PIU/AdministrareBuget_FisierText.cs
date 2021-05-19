
using System;
using System.Collections;
using System.IO;


namespace Proiect_PIU
{
    public class AdministrareBuget_FisierText : IstocareData
    {
        string NumeFisier { get; set; }

        public AdministrareBuget_FisierText(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();

        }
        public void AddBuget(Buget b)
        {
            try
            {

                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {
                    swFisierText.WriteLine(b.ConversieLaSir_PentruScriereInFisier());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }
        public Buget GetBuget(string tip, string provenienta)
        {
            try
            {

                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Buget buget = new Buget(line);
                        if (buget.Tip.Equals(tip) && buget.Provenienta.Equals(provenienta))
                            return buget;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }
        public ArrayList GetBugetTotal()
        {
            ArrayList bugete = new ArrayList();

            try
            {

                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Buget bugetDinFisier = new Buget(line);
                        bugete.Add(bugetDinFisier);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return bugete;
        }
        public bool UpdateBuget(Buget BugetActualizat)
        {
            ArrayList BugetTotal = GetBugetTotal();
            bool actualizareCuSucces = false;
            try
            {

                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Buget buget in BugetTotal)
                    {
                        Buget BugetPentruScrisInFisier = buget;

                        if (buget.Provenienta == BugetActualizat.Provenienta)
                        {
                            BugetPentruScrisInFisier = BugetActualizat;
                        }
                        swFisierText.WriteLine(BugetPentruScrisInFisier.ConversieLaSir_PentruScriereInFisier());
                    }
                    actualizareCuSucces = true;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return actualizareCuSucces;
        }
        public Buget GetBuget(string tip)
        {
            try
            {

                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Buget buget = new Buget(line);
                        if (buget.Tip.Equals(tip))
                            return buget;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;

        }
        public ArrayList GetBugetTotal(string tip)
        {
            ArrayList bugete = new ArrayList();

            try
            {

                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Buget bugetDinFisier = new Buget(line);
                        if(bugetDinFisier.Tip.Equals(tip))
                        bugete.Add(bugetDinFisier);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return bugete;
        }

    }

}

