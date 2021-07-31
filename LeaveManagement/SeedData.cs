using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement
{
    public static class SeedData
    {
        public static void Seed(UserManager<Employee> userManager,RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUSers(userManager);
        }
        private static void SeedUSers(UserManager<Employee> userManager)
        {
            //We are adding  administrator user in this fuction
            if (userManager.FindByNameAsync("").Result == null) 
            {
                var user = new Employee
                {
                    UserName = "admin@localhost.com",
                    Email = "admin@localhost.com"
                };
                var result = userManager.CreateAsync(user, "Admin@123").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                }
            }
        }
        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            //We Are adding two Roles
            //1. Administrator
            //2. Employee
            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Administrator"
                };
            var result = roleManager.CreateAsync(role).Result;
                
            }
            if (!roleManager.RoleExistsAsync("Employee").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Employee"
                };
              var result = roleManager.CreateAsync(role).Result;
            }
        }
    }
}
