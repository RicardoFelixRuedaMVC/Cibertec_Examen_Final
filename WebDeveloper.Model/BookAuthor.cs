using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    public partial class BookAuthor
    {
        [Key]
       
        public int? au_id { get; set; }
        [Key]
        public int? title_id { get; set; }


        [StringLength(20)]
        [Display(Name = "Au_ord:")]
        public string au_ord { get; set; }
        [StringLength(20)]
        [Display(Name = "Royaltyper:")]
        public string royaltyper { get; set; }


        //[Display(Name = "List Categories:")]
        [ForeignKey("au_id")]
        public virtual Authors Authors { get; set; }

        [ForeignKey("title_id")]
        public virtual Books Books { get; set; }





    }
}
