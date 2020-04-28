using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WalkingDinnerWebApp.Models
{
    public class Group : Person
    {
        public int CoupleId { get; set; }
        
        public Person Person1 { get; set; }
        public Person Person2 { get; set; }
    }
}
