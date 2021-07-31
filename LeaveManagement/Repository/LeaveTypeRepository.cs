﻿using LeaveManagement.Contracts;
using LeaveManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveType entity)
        {
            _db.LeaveTypes.Add(entity);
            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _db.LeaveTypes.Remove(entity);
            return Save();
        }

        public ICollection<LeaveType> FindAll()
        {
            var leaveTypes = _db.LeaveTypes.ToList();
            return leaveTypes;
        }

        public LeaveType FindByID(int ID)
        {
            var leaveType = _db.LeaveTypes.Find(ID);
            return leaveType;
            //Alternatively
            //_db.LeaveTypes.FirstOrDefault();
        }

        public ICollection<LeaveType> GetEmployeesByLeaveType(int ID)
        {
            throw new NotImplementedException();
        }

        public bool isExists(int id)
        {
            var exists = _db.LeaveTypes.Any(q => q.ID == id);
            return exists;
        }

        public bool Save()
        {
          var changes =  _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(LeaveType entity)
        {
            _db.LeaveTypes.Update(entity);
            return Save();
            
        }
    }
}
