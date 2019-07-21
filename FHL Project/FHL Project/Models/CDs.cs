using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FHLProject.Models
{
    public class CDs
    {
        [Key]
        public int cdID { get; set; }
        public int CD_Number { get; set; }//four digit code (PK)
        public int QS_Number { get; set; }// six digit code (CD_Number with leading zeros)
        public int Concurrent { get; set; } //number of concurrent users?
        public DateTime Update_Date { get; set; }//date the record was last updated
        public string CD_Titles { get; set; }//Name of CD
        public int Title_Number { get; set; }//?
        public string CD_Surname { get; set; }//Surname being researched
        public string CD_Place { get; set; }//Place being researched
        public string Location { get; set; } // Location in server
    }
}
