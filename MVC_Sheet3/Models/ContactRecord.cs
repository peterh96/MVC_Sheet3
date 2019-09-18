using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Sheet3.Models
{
    public class ContactRecord
    {
        
        public int Id { get; set; }
        public String FName { get; set; }
        public String LName { get; set; }

        public String PhoneNum_mobile { get; set; }
        public String PhoneNum_Home { get; set; }
        public String PhoneNum_Business { get; set; }
        public String Address { get; set; }
        public String Notes { get; set; }

        //indicates if a record is active
        //(if it's false, the record is basically 'deleted')
        public Boolean IsActive { set; get; }
    }
}