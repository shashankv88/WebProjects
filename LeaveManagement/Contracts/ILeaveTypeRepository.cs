using LeaveManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Contracts
{
    public interface ILeaveTypeRepository : IRepositoryBase<LeaveType>
    {
        //This repository Defines the database operations that are implemented.s
        ICollection<LeaveType> GetEmployeesByLeaveType(int ID);
    }

}
