using eTicketMovieSystem.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketMovieSystem.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Logo")]
        public string Logo { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Name is required!")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Name must be between 6 and 50 character")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Description is required!")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Description must be between 6 and 50 character")]

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
