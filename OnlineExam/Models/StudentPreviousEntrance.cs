using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace OnlineExam.Models
{
    [Table("[Student_PreviousEntrance]")]
    public class StudentPreviousEntrance
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string PrevEntranceExamName { get; set; }
        public string RollNo { get; set; }


        public string AttemptedYear
        { get; set; }
        public string Mark
        { get; set; }
        public int Rank
        { get; set; }
        public int NoOfAttempts
        { get; set; }




        //[ForeignKey("Id")]
        //public User Users { get; set; }
    }
}