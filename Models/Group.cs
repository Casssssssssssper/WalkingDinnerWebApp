using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WalkingDinnerWebApp.Models
{
    public class Group : Person
    {
        public int CoupleId { get; set; }
        
        public Person PersonOne { get; set; }
        public Person PersonTwo { get; set; }
        /*
        Being able to add more people
         */
        
    }
}
