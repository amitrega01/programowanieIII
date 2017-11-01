using System;
using System.Collections.ObjectModel;

namespace Lotniasko
{
    class Pilot
    {
        private String _Imie { get; set; }
        private String _Nazwisko { get; set; }

        public Pilot(string imie, string nazwisko)
        {
            _Imie = imie;
            _Nazwisko = nazwisko;
        }

        public override string ToString()
        {
            return $"{_Nazwisko} {_Imie}";
        }
    }

    class Samolot
    {
        private int _Id { get; set; }
        private String _Marka { get; set; }
        private String _Model { get; set; }
        private Pilot _Pilot { get; set; }
        private int _IlPasazerow { get; set; }
        private int _Gate { get; set; }

        public Samolot(int id, string marka, string model, Pilot pilot, int ilPasazerow, int gate)
        {
            _Id = id;
            _Marka = marka;
            _Model = model;
            _Pilot = pilot;
            _IlPasazerow = ilPasazerow;
            _Gate = gate;
        }

        public override string ToString()
        {
            return
                $"G: {_Gate}\t{_Marka}\t{_Model}\tID: {_Id}\tPilot: {_Pilot}\tIl.Pasażerów: {_IlPasazerow}";
        }
    }

    class Odlot
    {
        private int _NrLotu { get; set; }
        private String _Dokad { get; set; }
        private Samolot _Samolot { get; set; }
        private DateTime _DateTime { get; set; }

        public Odlot(int nrLotu, string dokad, Samolot samolot, DateTime dateTime)
        {
            _NrLotu = nrLotu;
            _Dokad = dokad;
            _Samolot = samolot;
            _DateTime = dateTime;
        }

        public override string ToString()
        {
            return
                $"Nr Lotu: {_NrLotu}\n\rDo: {_Dokad}\tGodzina: {_DateTime.ToShortTimeString()}\n\r{_Samolot} \n\r";
        }
    }

    class Przylot
    {
        private int _NrLotu { get; set; }
        private String _Skad { get; set; }
        private Samolot _Samolot { get; set; }
        private DateTime _DateTime { get; set; }

        public Przylot(int nrLotu, string skad, Samolot samolot, DateTime dateTime)
        {
            _NrLotu = nrLotu;
            _Skad = skad;
            _Samolot = samolot;
            _DateTime = dateTime;
        }

        public override string ToString()
        {
            return
                $"Nr Lotu: {_NrLotu}\n\rDo: {_Skad}\tGodzina: {_DateTime.ToShortTimeString()}\n\r{_Samolot} \n\r";
        }
    }

    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("LOTNISKO im. Adama Mitręgi");

            //dodawanie samolotow 

            int a = 1;
            Collection<Samolot> Samoloty = new Collection<Samolot>();
            Samoloty.Add(new Samolot(a++, "Boeing", "747", new Pilot("Adam", "Mitręga"), 320, 2));
            Samoloty.Add(new Samolot(a++, "Boeing", "777", new Pilot("Jan", "Kowalski"), 330, 13));
            Samoloty.Add(new Samolot(a++, "Airbus", "A300", new Pilot("Tadzio", "Nowak"), 280, 3));
            Samoloty.Add(new Samolot(a++, "Airbus", "A310", new Pilot("Geralt", "Pijaczyna"), 350, 5));


            Console.WriteLine("LISTA SAMOLOTÓW NA LOTNISKU");
            foreach (var s in Samoloty)
                Console.WriteLine(s.ToString());


            //dodawanie odlotow

            int b = 1;
            Collection<Odlot> Odloty = new Collection<Odlot>();
            Odloty.Add(new Odlot(b++, "Rio", Samoloty[0], new DateTime(2017, 10, 31, 12, 31, 11)));
            Odloty.Add(new Odlot(b++, "Radom", Samoloty[1], new DateTime(2017, 10, 31, 14, 21, 11)));
            Odloty.Add(new Odlot(b++, "Berlin", Samoloty[3], new DateTime(2017, 10, 31, 14, 44, 32)));


            Console.WriteLine("ODLOTY:");
            foreach (var o in Odloty)
                Console.WriteLine(o.ToString());


            //dodawanie przylotów

            int c = 1;
            Collection<Przylot> Przyloty = new Collection<Przylot>();
            Przyloty.Add(new Przylot(c++, "Rio", Samoloty[2], new DateTime(2017, 10, 31, 12, 31, 11)));


            Console.WriteLine("PRZYLOTY:");
            foreach (var p in Przyloty)
                Console.WriteLine(p.ToString());
        }
    }
}