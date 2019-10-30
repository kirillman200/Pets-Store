using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace A1_200412952.Models
{
    public class Animal
    {
        public Animal() { }
        public Animal(int AnimalId, String Name, String Description)
        {
            this.AnimalId = AnimalId;
            this.Name = Name;
            this.Description = Description;

        }

        [Key]
        public virtual int AnimalId { get; set;  }


        [Required]
        [Display(Name = "Breed")]
        public virtual String Name { get; set; }
        
        public virtual String Description { get; set; }

        public virtual List<PetFood> PetFoods { get; set; }

    }
}
