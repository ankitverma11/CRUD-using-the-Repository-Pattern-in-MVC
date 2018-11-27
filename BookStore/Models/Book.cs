using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    //This model is actually a class that uses an entity and entity set.We create the Book class under Models and implements Code First data annotation for database table that will be created by it.
    public class Book
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Title { get; set; }
        public string Authers { get; set; }

        [Column("Year")]
        [Display(Name ="Publish Year")]
        public string publishYear { get; set; }

        [Column("Price")]
        [Display(Name = "Price")]
        public string BasePrice { get; set; }
    }
}