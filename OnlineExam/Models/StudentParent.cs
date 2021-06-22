using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineExam.Models
{
    [Table("[Student_Parent]")] 
    public class StudentParent
    {
    
        public int Id { get; set; }
        public int UserId { get; set; }
       

        public string FrName { get; set; }
        public string FrOcc { get; set; }

   
        public string FrMobNo { get; set; }
        public string FrMailId { get; set; }

        public string FrDistrict { get; set; }
        public string FrSign { get; set; }
        public string FrState { get; set; }


        public string FrWhatsApp { get; set; }

    


        public string MrName { get; set; }
        public string MrOcc { get; set; }


        public string MrMobNo { get; set; }
        public string MrMailId { get; set; }
        
        public string MrDistrict { get; set; }
        public string MrSign { get; set; }
        public string MrState { get; set; }
        public string MrWhatsApp { get; set; }


        //[ForeignKey("Id")]
        //public User Users { get; set; }
    }
}