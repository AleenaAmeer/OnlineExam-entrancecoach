using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineExam.Models
{

    [Table("[Student_AcademicPerformance]")]
    public class StudentAcademicPerformance
    {


     
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Class { get; set; }
        public string PassYear { get; set; }


        public string SchoolAddress { get; set; }
        public string RegNo { get; set; }
        public string Board { get; set; }
        public string PhyMark { get; set; }
        public string ChemMark { get; set; }
        public string BiologyMark { get; set; }


        public string MathsMark { get; set; }

        public string PercOfMark { get; set; }
        //[ForeignKey("Id")]
        //public User Users { get; set; }
    }
}