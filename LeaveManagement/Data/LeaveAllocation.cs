﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Data
{
    public class LeaveAllocation
    {
        [Key]
        public int ID { get; set; }
        public int NumberofDays { get; set; }
        public DateTime DateCreated { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
        public string EmployeeID { get; set; }
        [ForeignKey("LeaveTypeID")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeID { get; set; }

        public int Period { get; set; }
    }
}
