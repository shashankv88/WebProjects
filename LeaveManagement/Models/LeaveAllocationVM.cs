
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class LeaveAllocationVM
    {
        [Key]
        public int ID { get; set; }
        
        [Display(Name = "Number Of Days")]
        public int NumberofDays { get; set; }
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }
        public int Period { get; set; }
        //This Code Below add 1 object of Employee Info and Leave Type Info
        public EmployeeVM Employee { get; set; }
        public string EmployeeID { get; set; }
        
        public LeaveTypeVM LeaveType { get; set; }
        public int LeaveTypeID { get; set; }
        //In Order to Get all Objects related to Employee and Leave Type
        //public IEnumerable<SelectListItem> Employees { get; set; }
        //public IEnumerable<SelectListItem> LeaveTypes { get; set; }


    }
    public class CreateLeaveAllocationVM
    {
        public int Numberupdated { get; set; }
        public List<LeaveTypeVM> LeaveTypes { get; set; }
    }
    public class EditLeaveAllocationVM
    {
        public int ID { get; set; }
        public EmployeeVM Employee { get; set; }

        public string EmployeeID { get; set; }
        [Display(Name = "Number of Days")]
        public int NumberofDays { get; set; }
        public LeaveTypeVM LeaveType { get; set; }

    }
    public class ViewLeaveAllocationVM
    {
       public EmployeeVM Employee { get; set; }
        public string EmployeeID { get; set; }
        public List<LeaveAllocationVM> LeaveAllocations { get; set; } 
    }
}
