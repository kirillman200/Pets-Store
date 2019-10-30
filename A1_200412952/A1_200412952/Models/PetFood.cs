using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace A1_200412952.Models
{
    public class PetFood
    {
      
        public virtual int Id { get; set; }
        [DataType(DataType.Currency)]
        public virtual Decimal Price { get; set; }
        [Required]
        [Display(Name="Food Name")]
        public virtual String Name { get; set; }

        public virtual String Description { get; set; }

        public virtual String ImageUrl { get; set; }

        [Required]
        [Display(Name = "Nutritional Information")]
        public virtual String NutritionalInformation { get; set; }

        [Required]
        [Display(Name = "Weight in kg")]
        public virtual float Weight { get; set; }

        public virtual String Brand { get; set; }

        [Required]
        public virtual int AnimalId { get; set; }

        
        [Display(Name = "Animal Breed")]
        public virtual Animal TypeOfAnimal { get; set; }

    }
}
