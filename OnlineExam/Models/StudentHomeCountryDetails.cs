using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace OnlineExam.Models
{
    [Table("[Student_HomeCountryDetails]")]
    public class StudentHomeCountryDetails
    {


        public int Id { get; set; }
        public int UserId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }


        public string AreaHome { get; set; }
        public string PincodeHome { get; set; }
        public string QuickContact { get; set; }
        public string LocationHome { get; set; }
        public string StateHome { get; set; }
        public string EmaiId { get; set; }


        public string QuickHomeWhatsapp { get; set; }


        //[ForeignKey("Id")]
        //public User Users { get; set; }
    }
}