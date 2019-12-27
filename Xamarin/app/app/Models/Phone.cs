using System;
using System.Collections.Generic;
using System.Text;

namespace app.Models
{
  public enum TypeContact
    {
        PhoneNumber,
        Email,
        Facebook,
        Twitter,
        LinkedIN,

    }
    public class Phone
    {
       
        public int PhoneID { get; set; }
   
        public string Name { get; set; }
        public TypeContact Type { get; set; }

        public string Contact { get; set; }
    }
}
