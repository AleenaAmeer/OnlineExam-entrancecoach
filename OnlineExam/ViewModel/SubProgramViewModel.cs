using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

using OnlineExam.Models;


namespace OnlineExam.ViewModel
{
    public class SubProgramViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        public int? Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int IsDeleted { get; set; }
        public DateTime DeletedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedTime { get; set; }

        [Required]
        [Display(Name = "Programme")]
        public int PgmId { get; set; }
        public IEnumerable<Programmes> Programme { get; set; }
    }
}