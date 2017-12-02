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
        public class SampleData
        {
            public List<Country> Countries;
            public List<PersonData> People;

            public SampleData()
            {
                Countries = new List<Country>();
                People = new List<PersonData>();

                Countries.Add(new Country(1, "United Kingdom"));
                Countries.Add(new Country(2, "United States"));
                Countries.Add(new Country(3, "Republic of Ireland"));
                Countries.Add(new Country(4, "Ivory Coast"));

                People.Add(new PersonData(1, 1, "AJson"));
                People.Add(new PersonData(2, 2, "Fred"));
                People.Add(new PersonData(3, 2, "Mary"));
            }
        }

        
        static void Main(string[] args)
        {
            //comments
        }
    }
}
