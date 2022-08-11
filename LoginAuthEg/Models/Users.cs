using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace LoginAuthEg.Models
{
    public class Users
    {
        //Primary key
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public stiring Confpassword{get:set:}
        
    }
}
