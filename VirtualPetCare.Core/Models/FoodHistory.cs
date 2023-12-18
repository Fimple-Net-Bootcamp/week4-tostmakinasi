﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetCare.Core.Models
{
    public class FoodHistory : BaseModel
    {
        public int PetId { get; set; }
        public int FoodId { get; set; }
        public int HealthEffect { get; set; }

        public Food Food { get; set; }
        public Pet Pet { get; set; }
    }
}
