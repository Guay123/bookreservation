using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mess.Models
{
    public class Class1
    {
        [Required(ErrorMessage = "Enter ID Number")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Numbers only please")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Enter First Name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public String fname { get; set; }
        [Required(ErrorMessage = "Enter Last Name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public String lname { get; set; }
        [Required(ErrorMessage = "Please Enter Username")]
        public String Uname { get; set; }
        [Required(ErrorMessage = "Please Password")]
        public String Pword { get; set; }
    }
}