using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Course_8_1.Models
{
     [Bind(Exclude = "Country")]
      
    public class ProjectEvaluation : IValidatableObject
    {
        [StringLength(30)]
        [Required]
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        [Range(1, 10)]
        [Required]
        public double Rating { get; set; }
        public int Id { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validatonContext)
        {
            if (Rating < 2){
                yield return new ValidationResult("Sorry " + Name + ", you can't do it!");
            }
        }
    }
}