using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Immutable;
using System.Collections.ObjectModel;

namespace WalkingDinnerWebApp.Models
{
    public class Course
    {
        public int GroupSize { get; set; }
      
        public int MaxPeople { get; set; }
        public int MaxCouples { get; set; }
    }

   
}
