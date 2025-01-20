using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarvajalJProgreso3.Models
{
    public class CarvajalPaisAPI
    {

        public class Rootobject
        {
            public Class1[] Property1 { get; set; }
        }

        public class Class1
        {
            public Name name { get; set; }
            public string[] tld { get; set; }
            public string cca2 { get; set; }
            public string ccn3 { get; set; }
            public string cca3 { get; set; }
            public string cioc { get; set; }
            public bool independent { get; set; }
            public string status { get; set; }
            public bool unMember { get; set; }
            public Currencies currencies { get; set; }
            public Idd idd { get; set; }
            public string[] capital { get; set; }
            public string[] altSpellings { get; set; }
            public string region { get; set; }
            public string subregion { get; set; }
            public Languages languages { get; set; }
            public float[] latlng { get; set; }
            public bool landlocked { get; set; }
            public string[] borders { get; set; }
            public float area { get; set; }
            public string flag { get; set; }
            public Maps maps { get; set; }
            public int population { get; set; }
            public string fifa { get; set; }
            public string[] timezones { get; set; }
            public string[] continents { get; set; }
            public Flags flags { get; set; }
            public string startOfWeek { get; set; }
            public Capitalinfo capitalInfo { get; set; }
        }

        public class Name
        {
            public string common { get; set; }
            public string official { get; set; }
            public Nativename nativeName { get; set; }
        }

        public class Nativename
        {
            public Spa spa { get; set; }
        }

        public class Spa
        {
            public string official { get; set; }
            public string common { get; set; }
        }

        public class Currencies
        {
            public USD USD { get; set; }
        }

        public class USD
        {
            public string name { get; set; }
            public string symbol { get; set; }
        }

        public class Idd
        {
            public string root { get; set; }
            public string[] suffixes { get; set; }
        }

        public class Languages
        {
            public string spa { get; set; }
        }

        

        

        public class Maps
        {
            public string googleMaps { get; set; }
            public string openStreetMaps { get; set; }
        }

        
        public class Flags
        {
            public string png { get; set; }
            public string svg { get; set; }
            public string alt { get; set; }
        }

     
        public class Capitalinfo
        {
            public float[] latlng { get; set; }
        }

        
    }
}
