using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProjectScrape
{
    class Program
    {
        public class PersonData
        {
            public int ID { get; set; }
            public string PersonName { get; set; }
            public int Nationality { get; set; }

            public PersonData(int id, int nationality ,string Name)
            {
                ID = id;
                PersonName = Name;
                Nationality = nationality;
            }
        }

        public class Country
        {
            public int ID { get; set; }
            public string CountryName { get; set; }

            public Country(int id, string Name)
            {
                ID = id;
                CountryName = Name;
            }
        }
        static void Main(string[] args)
        {
            //comments
        }
    }
}
