using eTicketMovieSystem.Data;
using eTicketMovieSystem.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketMovieSystem.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Moive name")]
        [Required(ErrorMessage = "Moive name is required")]
        public string Name { get; set; }

        [Display(Name = "Moive description")]
        [Required(ErrorMessage = "Moive description is required")]
        public string Description { get; set; }

        [Display(Name = "price in ZAR ")]
        [Required(ErrorMessage = "Price is required")]
        public Double Price { get; set; }

        [Display(Name = "Moive poster ")]
        public string ImageUrl { get; set; }

        [Display(Name = "Start date")]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End date ")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Moive category is required")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships

        [Display(Name = "Select Actor(s)")]
        [Required(ErrorMessage = "Moive actor(s) is required")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Select a cinema")]
        [Required(ErrorMessage = "Moive cinema is required")]
        public int CinemaId { get; set; }

        [Display(Name = "Select a producer")]
        [Required(ErrorMessage = "Moive producer is required")]
        public int ProducerId { get; set; }
        
    }
}
