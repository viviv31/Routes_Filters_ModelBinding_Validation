using System;

namespace Routes_Filters_ModelBinding_Validation.Models
{


    public class Food
    {
        public string Line1 { get; set; }
        public string Type { get; set; }
        public string store { get; set; }
        public string Country { get; set; }



        public enum Role
        {
            Admin,
            User,
            Guest
        }
    }
}