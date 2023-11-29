using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT.View_Model
{
    public class View
    {
        [Key]

        public int R_ID { get; set; }

        public int stud_ID { get; set; }
        public string NAME { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int PH_number { get; set; }
        public string Gender { get; set; }
        public string E_ID { get; set; }



    }
}
