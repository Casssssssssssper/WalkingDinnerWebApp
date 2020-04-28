using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WalkingDinnerWebApp.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string tussenVoegsel { get; set; }
        public string achterNaam { get; set; }



        enum VoorkeurBereidingGerecht
        {
            KoudVoorgerecht,
            WarmVoorgerecht,
            Hoofdgerecht,
            Dessert,
            Zoetigheden
        }

        internal string StreetName { get; set; }
        internal int HouseNumber { get; set; }
        internal string PostCode { get; set; }
        internal string Country { get; set; }
        internal string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string dieetWensen { get; set; }
        public string ZipCode { get; set; }
        
       
    }
}
