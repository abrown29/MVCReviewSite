using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewSite.Models
{
    public class Review //the actual review
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        [Display(Name ="Published Date")]
        public DateTime PublishedDate { get; set; }

        [ForeignKey("Category")]
        [Display(Name ="Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}