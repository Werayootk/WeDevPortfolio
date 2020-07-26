using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeDevPortfolio.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [Display(Name = "Project ID")]
        public int ProjectID { get; set; }

        [Required]
        [StringLength(150)]
        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }

      
        [StringLength(500)]
        [Display(Name = "Project Content")]
        public string ProjectContent { get; set; }

        
        [StringLength(50)]
        [Display(Name = "Project Status")]
        public string ProjectStatus { get; set; }

        [StringLength(500)]
        [Display(Name = "Project Url")]
        public string ProjectURL { get; set; }


        [StringLength(500)]
        [Display(Name = "Project Url Img")]
        public string ProjectURLIMG { get; set; }
    }
}
