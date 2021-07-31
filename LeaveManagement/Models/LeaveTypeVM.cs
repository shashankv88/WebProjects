using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    //We Can Create Different VM according to our requirement
    public class LeaveTypeVM
    {

        public int ID { get; set; }
        [Display(Name = "Leave Name")]
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1,25,ErrorMessage ="Please Enter A Valid Member")]
        [Display(Name = "Default Number Of Days")]
        public int DefaultDays { get; set; }
        [Display(Name ="Date Created")]
        public DateTime? DateCreated { get; set; }
    }
    
}
