using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WalkingDinnerWebApp.Models
{
    public class Person
    {
        internal int Id { get; set; }
        internal string firstName { get; set; }
        internal string tussenVoegsel { get; set; }
        internal string lastName { get; set; }



        enum PreferableDish
        {
            KoudVoorgerecht,
            WarmVoorgerecht,
            Hoofdgerecht,
            Dessert            
        }

        internal string StreetName { get; set; }
        internal int HouseNumber { get; set; }
        internal string PostCode { get; set; }
        
        internal string Email { get; set; }
        internal int PhoneNumber { get; set; }
        internal string DietWishes { get; set; }
        internal string ZipCode { get; set; }
        
       
    }
}
