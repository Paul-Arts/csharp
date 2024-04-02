// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    public class Vak
    {
        private String naam;
        private String lescode;
        public Vak(String naam, String lescode)
        {
            this.naam = naam;
            this.lescode = lescode;
        }
    }

//Klasse Docent:
//using System;
//using System.Collections.Generic; // Om List te kunnen gebruiken!
//namespace ConsoleApp1

    public class Docent
    {
        private String naam;
        private String bsn;
        private int salaris;
        private List<Vak> vakken;
        public Docent(String naam, String bsn, int salaris)
        {
            this.naam = naam;
            this.bsn = bsn;
            this.salaris = salaris;
            this.vakken = new List<Vak>();
        }
        public void Lesgeven()
        {
            Console.WriteLine(this.naam + " geeft les!");
        }
        public void VakToevoegen(String naam, String lescode)
        {
            Vak vak = new Vak(naam, lescode);
            vakken.Add(vak);
        }
    }
public class Student
    {
        private String naam;
        private String bsn;
        private int studieschuld;
        public Student(String naam, String bsn, int studieschuld)
        {
            this.naam = naam;
            this.bsn = bsn;
            this.studieschuld = studieschuld;
        }
        public void studeren()
        {
            Console.WriteLine(this.naam + " studeert!");
        }
    }
//Hoofdprogramma:
//using System;
//namespace ConsoleApp1

    class Program
    {
        static void Main(string[] args)
        {
            Docent d1 = new Docent("Jan", "123", 3550);
            Docent d2 = new Docent("Marie", "234", 4700);
            d1.Lesgeven();
            d2.Lesgeven();
            d1.VakToevoegen("Frans", "fr");
            d1.VakToevoegen("Wiskunde", "wi");
            Student s1 = new Student("Anna", "999", 15000);
            Student s2 = new Student("Henk", "333", 27000);
            s1.studeren();
            s2.studeren();
        }
    }

}
