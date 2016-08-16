using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    public partial class Books
    {

        [Key]
        public int title_id { get; set; }

        [Required(ErrorMessage = "The Book title is required")]
        [Display(Name = "Book title:")]
        [StringLength(40)]
        public string title { get; set; }

        public int pub_id { get; set; }

        [StringLength(20)]
        [Display(Name = "type:")]
        public string type { get; set; }

        [Column(TypeName = "money")]
        [Display(Name = "Price:")]
        public decimal? Price { get; set; }

        [Display(Name = "advanced:")]
        public string advanced { get; set; }

        [Display(Name = "Royalty:")]
        public string royalty{ get; set; }

        [Display(Name = "ytd_sales:")]
        public string ytd_sales { get; set; }

        [Display(Name = "notes:")]
        public string notes { get; set; }

        [Display(Name = "pubsate:")]
        public string pubdate { get; set; }


    }
}
