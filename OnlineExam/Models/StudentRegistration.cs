using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineExam.Models
{
    [Table("Student_Registration")]
    public class StudentRegistration
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }

        public int BatchId { get; set; }

        public string ExamAttendingYear { get; set; }
        public string PreferredDay { get; set; }

        public DateTime ApplnDate { get; set; }
        public string AcademicYear { get; set; }
        public DateTime AdmissionTestDate { get; set; }

        public TimeSpan PreferredTime { get; set; }
        public string WhatsappNo { get; set; }
        public DateTime DOB { get; set; }
        public int Gender { get; set; }
        public string Religion { get; set; }
        public string Caste { get; set; }
        public string Community { get; set; }


        public string BloodGroup { get; set; }
        public string Nationalty { get; set; }
        public string PresentAddress { get; set; }
        public string Area { get; set; }
        public string Location { get; set; }

        public string State { get; set; }
        public string District { get; set; }
        public string Pincode { get; set; }
        public string QuickContNo { get; set; }
        public string Photo { get; set; }

        public string  QuickWhatsApp { get; set; }


        public int PgmId { get; set; }
        public int ClassId { get; set; }
        public int CourseId { get; set; }

        public int SubPgmId { get; set; }


      
        /*[ForeignKey("Id")]
        public User  Users{ get; set; }      */                           
    }
}