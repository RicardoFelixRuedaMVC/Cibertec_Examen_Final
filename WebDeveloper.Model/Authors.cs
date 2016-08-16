using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDeveloper.Model
{
    public partial class  Authors
    {
        [Key]
        public int au_id { get; set; }

        [Required(ErrorMessage = "The Last name author is required")]
        [Display(Name = "Author Last name:")]
        [StringLength(40)]
        public string au_lname { get; set; }

        [Required(ErrorMessage = "The firts name author is required")]
        [Display(Name = "Authorfirts name:")]
        [StringLength(40)]
        public string au_fname { get; set; }


        [StringLength(20)]
        [Column(TypeName = "phone")]
        [Display(Name = "phone:")]
        public string au_phone { get; set; }

      
        [Display(Name = "city:")]
        public string au_city { get; set; }

        [Display(Name = "state:")]
        public string au_state { get; set; }

        [Display(Name = "Zip:")]
        public string au_Zip { get; set; }

        [Display(Name = "sex:")]
        public string au_sex { get; set; }

        [Display(Name = "salary:")]
        public string au_salary { get; set; }

        [Display(Name = "subject:")]
        public string au_subject { get; set; }




    }
}
